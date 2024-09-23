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



        public NetSystem()
        {
            


            DataWallStrength = 5;
            Intelligence = 6;
            NumberOfCPUs = 2;

            Area outskirts = new Area("Outskirts of MiliTech sattelite office");


            Area west = new Area("West Side of Fortress");


            Area north = new Area("North Side of Fortress");
            NetProgram.CreateWatchDog(north, this);


            Area east = new Area("East Side of Fortress");
            NetProgram.CreateWatchDog(east, this);
            Area south = new Area("South Side of Fortress");
            NetProgram.CreateWatchDog(south, this);
            
            Area inner = new Area("Inner Fortress");
            NetProgram.CreateFile("File: Financial Transactions", inner, this);
            NetProgram.CreateFile("DB: Employee Records", inner, this);
            NetProgram.CreateFile("VR: Fractal Conference Room", inner, this);
            NetProgram.CreateFile("File: Business Records (Procurement), Gray Ops (bribes)", inner, this);
            NetProgram.CreateFile("File: Black Ops (Assassinations), Black Ops (Secret Weapon under development)", inner, this);
            NetProgram.CreateFile("File: Black Ops (Bribes of US officials)", inner, this);
            NetProgram.CreateFile($"Microphone in Corp Rest Room", inner, this);
            NetProgram.CreateFile($"File: Interoffice memos, DB: Costumers", inner, this);
            NetProgram.CreateFile($"Terminal:Secretarial Area", inner, this);
            NetProgram.CreateFile($"Terminal: Executive Offices", inner, this);

            NetProgram.CreatePoisonFlatline(inner, this);
            NetProgram.CreateFlatline(inner, this);
            NetProgram.CreateHellHound(inner, this);
            NetProgram.CreateBrainWipe(inner, this);
            //NetProgram.CreateFile("Accesspoint: Militech Los Angeles Metroplex",inner, this);




            new Gate(west, north, 0, -1);
            new Gate(west, south, 0, -1);
            new Gate(west, inner, 3, -1);

            new Gate(north, east, 0, -1);
            new Gate(north, inner, 3, -1);

            new Gate(south, east, 0, -1);

            new Gate(east, inner, 4, -1);
            new Gate(outskirts, north, 0, -1);
            new Gate(outskirts, south, 0, -1);
            new Gate(outskirts, west, 0, -1);
            new Gate(outskirts, east, 0, -1);
            Areas.Add(outskirts);
            Areas.Add(west);
            Areas.Add(north);
            Areas.Add(east);
            Areas.Add(south);
            Areas.Add(inner);

        }
    }
}


