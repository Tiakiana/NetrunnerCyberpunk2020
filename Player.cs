using System.ComponentModel;

namespace NetrunnerConsole
{
    public class Deck
    {
        public string Name = "Awesome Destroyer Deck";

        public List<NetProgram> ProgramList = new List<NetProgram>();

    }
    public class Player : Entity
    {
        public int TraceStrength;
        public Deck CurrentDeckEquipped;

        public int InterfaceStrength;
        public int SystemKnowledge;
        public int Intelligence;
        public static Player inst;

        public int Stun = 0;


        //public List<NetProgram> MyPrograms = new List<NetProgram>();

        public List<NetProgram> ActivePrograms = new List<NetProgram>();
     


       /*
        try jackhammer
        Tjekker if( CurrentDeckEquipped.Any("Jackhammer")){
       
        Affyr jackhammer!
        }
        
        */

        public Func<int> ScanningAttempt  => () => { return InterfaceStrength + SystemKnowledge + Intelligence + RNG.D10(); };


        public Player(string name)
        {
            inst = this;
            Name = name;
            InterfaceStrength = 10;
            SystemKnowledge = 10;
            Intelligence = 10;
        }
    }


}
