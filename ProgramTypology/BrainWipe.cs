namespace NetrunnerConsole.ProgramTypology {
    public class BrainWipe : NetProgram {


        public BrainWipe(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck) : base(name, mU, programStrength, area, mySystem, deck) {

        }

        public override void Activate(object target) {

            int rollattacker = RNG.D10;
            int rolldefender = RNG.D10;
            List<NetProgram> protections = Player.inst.ActivePrograms.Where(x => x.ProgramType == ProgramType.Protection).ToList();
            int strength = (protections.Count > 0 ? protections.Max(x => x.ProgramStrength) : 0) + Player.inst.InterfaceStrength + Player.inst.Intelligence;
            Console.WriteLine($"The Brainwipe is hurled at you, {Player.inst.Name}; [{rollattacker + 10 + MySystem.Intelligence + ProgramStrength}]");
            Console.WriteLine($"You defend yourself [(roll){rolldefender} + (protection) {strength} + (interface) {Player.inst.InterfaceStrength} + (int) {Player.inst.Intelligence}]");

            if (rollattacker + ProgramStrength + MySystem.Intelligence + 10 >= rolldefender + strength + Player.inst.Intelligence + Player.inst.InterfaceStrength) {
                int roll = RNG.D6;

                Console.WriteLine($", but to no avail! You are take {roll} damage to your intelligence. Maybe you like teletubbies now?");
            }
            else {
                Console.WriteLine($", and with ease you avoid the attack");
            }

        }
    }
}
