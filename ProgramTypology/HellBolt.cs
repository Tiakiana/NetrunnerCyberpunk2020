namespace NetrunnerConsole.ProgramTypology
{
    public class HellBolt : NetProgram
    {
      

        public HellBolt(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck) : base(name, mU, programStrength, area, mySystem, deck)
        {
         
        }

        public override void Activate(object target)
        {

            int rollattacker = RNG.D10();
            int rolldefender = RNG.D10();
            List<NetProgram> evasions = Player.inst.ActivePrograms.Where(x => x.ProgramType == ProgramType.Protection).ToList();
            int strength = evasions.Count > 0 ? evasions.Max(x => x.ProgramStrength) : 0;
            Console.WriteLine($"The Hellbolt is hurled at you, {Player.inst.Name}; [{rollattacker} + {ProgramStrength}]");
            Console.WriteLine($"You defend yourself [{rolldefender} + {strength}");

            if (rollattacker + ProgramStrength >= rolldefender + strength)
            {
                int roll = RNG.D10();

                Console.WriteLine($", but to no avail! You are take {roll} damage.!");
            }
            else
            {
                Console.WriteLine($", and with ease you avoid the attack");
            }

        }
    }

}
