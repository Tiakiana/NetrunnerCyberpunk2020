using NetrunnerConsole.ProgramTypology;

namespace NetrunnerConsole
{
    public class NetSystem
    {
        public string SystemName;
        public int Intelligence;
        public int DataWallStrength;
        public int NumberOfCPUs;
        public bool Alerted;


        public List<Area> Areas = new List<Area>();
        public List<Entity> entities = new List<Entity>();

        public void OnTimePassesMe()
        {
            foreach (var item in Areas)
            {
                if (Player.inst.Area == item)
                {
                    if (Alerted)
                    {
                        foreach (NetProgram program in item.Entities.Where(x=> x.Team == 0 && x is NetProgram))
                        {
                            if (program is Flatline)
                            {
                            //Todo Fat hvorfor det her ikke virker
                           
                            }

                        }
                    }
                }
            }
        }


        public NetSystem()
        {

            Program.TimePasses += OnTimePassesMe;

            DataWallStrength = 5;
            Intelligence = 6;
            NumberOfCPUs = 2;

            //Area outskirts = new Area("Outskirts of MiliTech sattelite office");


            //Area west = new Area("West Side of Fortress");


            //Area north = new Area("North Side of Fortress");
            //NetProgram.CreateWatchDog(north, this);


            //Area east = new Area("East Side of Fortress");
            //NetProgram.CreateWatchDog(east, this);
            //Area south = new Area("South Side of Fortress");
            //NetProgram.CreateWatchDog(south, this);

            //Area inner = new Area("Inner Fortress");
            //NetProgram.CreateFile("File: Financial Transactions", inner, this);
            //NetProgram.CreateFile("DB: Employee Records", inner, this);
            //NetProgram.CreateFile("VR: Fractal Conference Room", inner, this);
            //NetProgram.CreateFile("File: Business Records (Procurement), Gray Ops (bribes)", inner, this);
            //NetProgram.CreateFile("File: Black Ops (Assassinations), Black Ops (Secret Weapon under development)", inner, this);
            //NetProgram.CreateFile("File: Black Ops (Bribes of US officials)", inner, this);
            //NetProgram.CreateFile($"Microphone in Corp Rest Room", inner, this);
            //NetProgram.CreateFile($"File: Interoffice memos, DB: Costumers", inner, this);
            //NetProgram.CreateFile($"Terminal:Secretarial Area", inner, this);
            //NetProgram.CreateFile($"Terminal: Executive Offices", inner, this);

            //NetProgram.CreatePoisonFlatline(inner, this);
            //NetProgram.CreateFlatline(inner, this);
            //NetProgram.CreateHellHound(inner, this);
            //NetProgram.CreateBrainWipe(inner, this);
            //NetProgram.CreateFile("Accesspoint: Militech Los Angeles Metroplex",inner, this);

            Area outskirts = new Area("Outskirts of Night City Harbor");


           
            Area harbour = new Area("Harbour Main", "The harbor seems derelict. Not a single ship is visible. This is strange!");
            NetProgram.CreateWatchDog(harbour,this);



            Area vessel = new Area("SS Navishall/Hordik", "Your target");
            NetProgram.CreateWatchDog(vessel,this);
            NetProgram.CreateFlatline(vessel,this);
            Useable useable = new Useable(vessel,this);

            
            
            new Gate(harbour, vessel, 4, -1,false);
            Area deathtrap = new Area("Arasaka Kujikiri", "this is not your target ship, and probably very deadly");
            
            
            NetProgram.CreateHellHound(deathtrap,this);
            NetProgram.CreateHellHound(deathtrap,this);
            NetProgram.CreateHellHound(deathtrap,this);
            NetProgram.CreateHellHound(deathtrap,this);
            NetProgram.CreatePoisonFlatline(deathtrap,this);
            NetProgram.CreatePoisonFlatline(deathtrap,this);
            NetProgram.CreatePoisonFlatline(deathtrap,this);

            new Gate(harbour,deathtrap,6,-1,false);
            Area ArasakaInner = new Area("Arasaka inner vessel sanctum");
            new Gate(deathtrap, ArasakaInner, 6, -1);

            Areas.Add(outskirts);
            new Gate(outskirts, harbour, 0, -1);
            Areas.Add(harbour);
            Areas.Add(vessel);
            Areas.Add(deathtrap);

          

        }
    }
}


