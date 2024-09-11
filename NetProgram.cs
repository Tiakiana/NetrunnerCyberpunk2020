namespace NetrunnerConsole
{
    public partial class NetProgram : Entity
    {

        public string Description;
        public int MU;
        public int ProgramStrength;
        public bool Derezzed;
        public Deck? Deck;
        public ProgramType ProgramType;

        public int CoolDown = 0;

        //Todo: Byg en måde at checke døre på
        public Func<int> ScanDefence => () => { return RNG.RollD10() + ProgramStrength + MySystem.DataWallStrength + (MySystem.Alerted ? 10 : 0); };

        public NetProgram(string name, int mU, int programStrength, Area area, NetSystem mySystem)
        {
            Name = name;
            MU = mU;
            ProgramStrength = programStrength;
            Area = area;
            Area.Entities.Add(this);
            MySystem = mySystem;

            switch (name)
            {
                case "Watch_Dog":
                    Activate = WatchDogLogic;
                    break;
                case "Invisibility":
                    Activate = InvisibilityLogic;
                    break;
            }
        }
        public NetProgram(string name, int mU, int programStrength, Deck deck)
        {
            Name = name;
            MU = mU;
            ProgramStrength = programStrength;
            
            

            switch (name)
            {
                case "Watch_Dog":
                    Activate = WatchDogLogic;
                    break;
                case "Invisibility":
                case "Stealth":
                    Activate = InvisibilityLogic;
                    break;
            }
        }


        public NetProgram(string name, int mU, int programStrength, Area area, NetSystem mySystem, ActivationDelegate activation)
        {
            Name = name;
            MU = mU;
            ProgramStrength = programStrength;
            Area = area;
            Area.Entities.Add(this);
            MySystem = mySystem;
            Activate = activation;
        }

        public void DeRezz()
        {
            MySystem.entities.Remove(this);
            Area.Entities.Remove(this);
        }

        public override string ToString()
        {
            return Name;
        }

        public ActivationDelegate Activate;

        public bool DetectPlayer(Player player, NetProgram entity)
        {
            List<NetProgram> evasions = player.ActivePrograms.Where(x=> x.ProgramType == ProgramType.Evasion).ToList();
            if (evasions == null || evasions.Count == 0)
            {
                return true;
            }

            int playerroll = RNG.RollD10() + evasions.Max(x=> x.ProgramStrength);
            Console.WriteLine($"[{player.Name}s evasion check was:  {playerroll}]"  );
            int computerRoll = RNG.RollD10() + entity.ProgramStrength;
            Console.WriteLine($"[{entity.Name}s evasion check was: " + computerRoll  );
            if (playerroll >= computerRoll)
            {
                entity.CoolDown = 1 + playerroll - computerRoll;
                return false;
            }
            return true;
        }

        public delegate string ActivationDelegate(params object[] objects);

      

    }
    public enum ProgramType
    {
        Evasion, AntiIC, Detection, AntiSystem, Decryptor, Protection, AntiPersonel, Controller, File, Intrusion, Utility, Demon
    }


    public partial class NetProgram :Entity
    {
        public static NetProgram CreateFile(string title, Area ares, NetSystem sys)
        {
            return new NetProgram(title, 2, 0, ares, sys);
        }

        public static NetProgram CreatePoisonFlatline(Area area, NetSystem sys)
        {
            return new NetProgram("Poison Flatline", 2, 2, area, sys);
        }

        public static NetProgram CreateWatchDog(Area area, NetSystem sys)
        {
            return new NetProgram("Watch_Dog", 5, 4, area, sys);
        }
        public static NetProgram CreateHellHound(Area area, NetSystem sys)
        {
            return new NetProgram("Hell_Hound", 6, 6, area, sys);
        }
        public static NetProgram CreateFlatline(Area area, NetSystem sys)
        {
            return new NetProgram("FlatLine", 2, 3, area, sys);
        }

        public static NetProgram CreateBrainWipe(Area area, NetSystem sys)
        {
            return new NetProgram("BrainWipe", 4, 3, area, sys);
        }

        public static NetProgram CreateInvisibility(Deck deck)
        {

            NetProgram res = new NetProgram("Invisibility", 1, 3, deck);
            res.ProgramType = ProgramType.Evasion;

            return res;

        }
        public static NetProgram CreateStealth(Deck deck)
        {

            NetProgram res = new NetProgram("Stealth", 3, 4, deck);
            res.ProgramType = ProgramType.Evasion;

            return res;

        }

        public static NetProgram CreateMurphy(Area area, NetSystem sys)
        {
            return new NetProgram("Murphy", 2, 3, area, sys);
        }

        public string WatchDogLogic(params object[] obs)
        {
            string res = "Watch_Dog starts sniffing around!\n";
            if (obs[0] is Player && DetectPlayer((Player)obs[0], this))
            {
                res += "Regina! Thou Art Found! Watch_Dog Locks on to you with dead canine eyes and starts barking!";
                MySystem.Alerted = true;
            }
            else
            {
                res += "Watch_Dog is not alerted for now. But it won't be long before it tries again";
            }

            Console.WriteLine(res);

            return res;
        }

        public string InvisibilityLogic(params object[] obs)
        {
            Player player = (Player)obs[0];
            player.ActivePrograms.Add(this);
            Console.WriteLine("A shimmer of benign static noise, that let's you hide your presence, surrounds you like a blizzard. You feel invisible!");
            return "A shimmer of benign static noise, that let's you hide your presence, surrounds you like a blizzard. You feel invisible!";
        }


    }


}

