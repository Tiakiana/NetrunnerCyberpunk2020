namespace NetrunnerConsole
{
    public class NetProgram : Entity
    {
        
        public string Description;
        public int MU;
        public int ProgramStrength;
        public bool Derezzed;
        //Todo: Byg en måde at checke døre på
        public Func<int> ScanDefence => () => { return RNG.RollD10() + ProgramStrength + MySystem.DataWallStrength + (MySystem.Alerted?10:0); };

     string nothing(params object[] obs) { return "nothing yet"; }
        public NetProgram(string name, int mU, int programStrength, Area area, NetSystem mySystem)
        {
            Name = name;
            MU = mU;
            ProgramStrength = programStrength;
            Area = area;
            Area.Entities.Add(this);
            MySystem = mySystem;
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


        public ActivationDelegate Activate;

        public delegate string ActivationDelegate(params object[] objects);

        public static NetProgram CreateFile(string title, Area ares, NetSystem sys)
        {
            return new NetProgram(title,2,0,ares, sys);
        }

        public static NetProgram CreatePoisonFlatline(Area area, NetSystem sys)
        {
            return new NetProgram("Poison Flatline",2,2,area, sys);
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
            return new NetProgram("FlatLine", 2, 3, area,sys);
        }

        public static NetProgram CreateBrainWipe(Area area, NetSystem sys)
        {
            return new NetProgram("BrainWipe",4, 3, area, sys);
        }

        public static NetProgram CreateMurphy(Area area, NetSystem sys)
        {
            return new NetProgram("Murphy", 2, 3, area,sys);
        }

    }
}


