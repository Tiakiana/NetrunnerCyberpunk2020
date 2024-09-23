using NetrunnerConsole.ProgramTypology;

namespace NetrunnerConsole
{
    public partial class NetProgram : Entity
    {

        public string Description;
        public int MU;
        public int ProgramStrength;
        public bool Derezzed { get { return Damage >= ProgramStrength; } }
        public Deck? Deck;
        public ProgramType ProgramType;
        public bool Encrypted;
        public int Damage;

        public int CoolDown { get; set; }

        //Todo: Byg en måde at checke døre på
        public Func<int> ScanDefence => () => { return RNG.D10 + ProgramStrength + MySystem.DataWallStrength + (MySystem.Alerted ? 10 : 0); };

     

        public NetProgram(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck)
        {
            Name = name;
            MU = mU;
            ProgramStrength = programStrength;
            Area = area;
            if (area!=null)
            {

            Area.Entities.Add(this);
            }
            MySystem = mySystem;
            Deck = deck;
        }

        public void DeRezz()
        {
            Console.WriteLine();
            Console.WriteLine( Name+ " screams as it Derezzes");
            MySystem.entities.Remove(this);
            Area.Entities.Remove(this);
        }

        public override string ToString()
        {
            return Name;
        }



        public virtual void Activate() {
        
        
        }
        public virtual void Activate(object obj)
        {


        }

        public bool DecryptGate(NetProgram attacker, Gate gate)
        {
            int attackerroll = RNG.D10;
            Console.WriteLine(attacker.Name + " tries to force open the gate [" + attackerroll+ " + "+ attacker.ProgramStrength);


            int defenderroll = RNG.D10;
            Console.WriteLine("The gate tries to resist! [" + defenderroll+ " + "+ gate.GateStrength);

            if (attackerroll+attacker.ProgramStrength>= defenderroll+gate.GateStrength)
            {
                Console.WriteLine("The gate is opened! ");
                gate.Broken = true;
                return true;
            }


            Console.WriteLine("The gate is unaffected.");
            return false;

            

        }

        public bool DecryptProgram(NetProgram attacker, NetProgram file)
        {
            int attackerroll = RNG.D10;
            Console.WriteLine(attacker.Name + " tries to force open the file [" + attackerroll + " + " + attacker.ProgramStrength);


            int defenderroll = RNG.D10;
            Console.WriteLine("The file tries to resist [" + defenderroll + " + " + file.ProgramStrength);

            if (attackerroll + attacker.ProgramStrength >= defenderroll + file.ProgramStrength)
            {
                Console.WriteLine("The file's resolve falters, it's secrets plain for you to read! ");
                file.Encrypted = false;
                return true;
            }


            Console.WriteLine("The file's secrets remain a mystery.");
            return false;


        }


        public bool DetectPlayer(Player player, NetProgram entity)
        {
            List<NetProgram> evasions = player.ActivePrograms.Where(x => x.ProgramType == ProgramType.Evasion).ToList();


            int playerroll = RNG.D10;
            int strength = evasions.Count > 0 ? evasions.Max(x => x.ProgramStrength) : 0;

            Console.WriteLine($"[{player.Name}s evasion check was:  {playerroll} + {strength}]");


            int computerRoll = RNG.D10 + entity.ProgramStrength;

            Console.WriteLine($"[{entity.Name}s evasion check was: " + computerRoll);

            if ((playerroll + strength) >= computerRoll)
            {
                entity.CoolDown = 1 + playerroll + strength - computerRoll;
                return false;
            }
            return true;
        }

        public static NetProgram CreateWizardsBook(Deck deck)
        {
            return new Decryptor("Wizard's Book", 2, 4,null,null ,deck);
        }  
        public static NetProgram CreateForceProtection(Deck deck)
        {
            return new Protection("ForceProtection", 2, 4,null,null ,deck);
        }
        public static NetProgram CreateStun(Deck deck)
        {
            return new Stun("Stun", 3, 3, null, null, deck);
        }

        public static NetProgram CreateHellBolt(Deck deck)
        {
            return new HellBolt("Hellbolt", 4, 4, null, null, deck);
        }

        public static NetProgram CreateKiller4(Deck deck)
        {
            return new Killer("Killer_IV", 5, 4, null, null, deck);
        }

        public static NetProgram CreateKiller2(Deck deck)
        {
            return new Killer("Killer_II", 5, 2, null, null, deck);
        }
        public static NetProgram CreateKiller6(Deck deck)
        {
            return new Killer("Killer_VI", 5, 6, null, null, deck);
        }

        internal static NetProgram CreateSeeYa(Deck currentDeckEquipped)
        {
            return new SeeYa("See Ya", 5, 6, null, null, currentDeckEquipped);
        }

        public delegate string ActivationDelegate(params object[] objects);



    }
    public enum ProgramType
    {
        Evasion, AntiIC, Detection, AntiSystem, Decryptor, Protection, AntiPersonel, Controller, File, Intrusion, Utility, Demon
    }


    public partial class NetProgram : Entity
    {
        public static NetProgram CreateFile(string title, Area ares, NetSystem sys, string content ="Some important info", int strength = 3)
        {
            return new NetFile(title, 2,strength, ares, sys,null,content);
        }

        public static NetProgram CreatePoisonFlatline(Area area, NetSystem sys)
        {
            return new PoisonFlatline("Poison Flatline", 2, 2, area, sys,null);
        }

        public static NetProgram CreateWatchDog(Area area, NetSystem sys)
        {
            return new WatchDog("Watch_Dog", 5, 4, area, sys,null);
        }
        public static NetProgram CreateHellHound(Area area, NetSystem sys)
        {
            return new HellHound("Hell_Hound", 6, 6, area, sys,null);
        }
        public static NetProgram CreateFlatline(Area area, NetSystem sys)
        {
            return new NetProgram("FlatLine", 2, 3, area, sys,null);
        }

        public static NetProgram CreateBrainWipe(Area area, NetSystem sys) {
            return new BrainWipe("BrainWipe", 4, 3, area, sys,null);
        }

        public static NetProgram CreateInvisibility(Deck deck)
        {

            NetProgram res = new Evasion("Invisibility", 1, 3,null,null, deck);
            res.ProgramType = ProgramType.Evasion;

            return res;

        }
        public static NetProgram CreateStealth(Deck deck)
        {

            NetProgram res = new Evasion("Stealth", 3, 4,null,null, deck);
            res.ProgramType = ProgramType.Evasion;

            return res;

        }

        //public static NetProgram CreateMurphy(Area area, NetSystem sys)
        //{
        //    return new NetProgram("Murphy", 2, 3, area, sys);
        //}

      

        public string InvisibilityLogic(params object[] obs)
        {
            Player player = (Player)obs[0];
            player.ActivePrograms.Add(this);
            Console.WriteLine("A shimmer of benign static noise, that let's you hide your presence, surrounds you like a blizzard. You feel invisible!");
            return "A shimmer of benign static noise, that let's you hide your presence, surrounds you like a blizzard. You feel invisible!";
        }

        public string SeeYaLogic(params object[] obs)
        {
            Console.WriteLine(  "Warning dumbass, this AINT DONE YET MORON!");
            if (obs[0] is Gate)
            {
                Gate gate = (Gate)obs[0];
                this.ProgramStrength = 6;
                DecryptGate(this, gate);
                this.ProgramStrength = 4;
            }

            if (obs[0] is NetProgram)
            {
                NetProgram prog = (NetProgram)obs[0];
                DecryptProgram(this, prog);
            }


            return "The silver shimmer fades.";
        }
    

    }


}

