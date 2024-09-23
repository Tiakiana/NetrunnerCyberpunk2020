namespace NetrunnerConsole.ProgramTypology
{
    public class HellHound : NetProgram, ITicker
    {


        public HellHound(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck) : base(name, mU, programStrength, area, mySystem, deck)
        {
            Name = name;
            MU = mU;
            Program.TimePasses += Tick;
        }
        ~HellHound()
        {
            Program.TimePasses -= Tick;

        }
        public void Tick()
        {
            if (Derezzed) {
                return;
            }

            if (Area.Entities.Any(x => x.Team != Team) && CoolDown <= 0)
            {
                Activate();
            }
            else
            {
                CoolDown--;
                if (Player.inst.Area == Area)
                {
                    Console.WriteLine("Hellhound leers in all directions, fire glowing from it's eyes (" + CoolDown +")");
                }
            }
        }
        public override void Activate()
        {
            string res = "";

            foreach (var item in Area.Entities.Where(x => x.Team != Team))
            {
                if (!MySystem.Alerted)
                {

                if (item is Player && DetectPlayer((Player)item, this))
                {
                    res += "Regina! Thou Art Found! The Hellhound springs forth, fangs bared and jets of flame shooting from it's nostrils.";
                    MySystem.Alerted = true;
                    res += "\n Alarms start blaring! The System knows you are here! Stealth is no longer an option, My Liege!";
                }
                else
                {
                    res += "Watch_Dog is not alerted for now. But it won't be long before it tries again";
                }

                }
                if (MySystem.Alerted)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    int rollattacker = RNG.D10;
                    int rolldefender = RNG.D10;
                    List<NetProgram> protections = Player.inst.ActivePrograms.Where(x => x.ProgramType == ProgramType.Protection).ToList();
                    int strength = (protections.Count > 0 ? protections.Max(x => x.ProgramStrength) : 0) + Player.inst.InterfaceStrength + Player.inst.Intelligence;
                    Console.WriteLine($"The HellHound Attacks relentlessly, {Player.inst.Name}; [{rollattacker + 10 + MySystem.Intelligence + ProgramStrength}]");
                    Console.WriteLine($"You steel yourself against the onslaught: [(roll){rolldefender} + (protection) {strength} + (interface) {Player.inst.InterfaceStrength} + (int) {Player.inst.Intelligence}]");

                    if (rollattacker + ProgramStrength + MySystem.Intelligence + 10 >= rolldefender + strength + Player.inst.Intelligence + Player.inst.InterfaceStrength)
                    {
                        int roll = RNG.D10 +RNG.D10;

                        Console.WriteLine($", but to no avail! You are taking {roll} damage.!");
                    }
                    else
                    {
                        Console.WriteLine($", and with ease you avoid the attack");
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            Console.WriteLine(res);

        }
    }

}
