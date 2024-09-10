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

        //public List<NetProgram> MyPrograms = new List<NetProgram>();

        public List<NetProgram> ActivePrograms = new List<NetProgram>();
     


       /*
        try jackhammer
        Tjekker if( CurrentDeckEquipped.Any("Jackhammer")){
       
        Affyr jackhammer!
        }
        
        */

        public Func<int> ScanningAttempt  => () => { return InterfaceStrength + SystemKnowledge + Intelligence + RNG.RollD10(); };


        public Player(string name)
        {
            Name = name;
            InterfaceStrength = 10;
            SystemKnowledge = 10;
            Intelligence = 10;
        }
    }


}
public enum ProgramNames
{
    Jackhammer,
    Daemon,
    Worm

}