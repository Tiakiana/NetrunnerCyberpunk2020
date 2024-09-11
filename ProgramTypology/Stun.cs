using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerConsole.ProgramTypology
{
    public class Stun : NetProgram
    {
      

        public Stun(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck) : base(name, mU, programStrength, area, mySystem, deck)
        {
        
        }

        public override void Activate()
        {

            int rollattacker = RNG.D10();
            int rolldefender = RNG.D10();
            List<NetProgram> evasions = Player.inst.ActivePrograms.Where(x => x.ProgramType == ProgramType.Protection).ToList();
            int strength = evasions.Count > 0 ? evasions.Max(x => x.ProgramStrength) : 0;
            Console.WriteLine($"The Stun fires at {Player.inst.Name}; [{rollattacker} + {ProgramStrength}]");
            Console.WriteLine($"You defend yourself [{rolldefender} + {strength}");

            if (rollattacker+ProgramStrength>= rolldefender+strength)
            {
                int roll = RNG.D6();

                if (Player.inst.Stun > roll)
                {
                    roll = Player.inst.Stun;
                }
                Player.inst.Stun = roll;
                Console.WriteLine($", but to no avail! You are stunned for {roll} turns!");
            }
            else
            {
                Console.WriteLine( $", and with ease you avoid the attack");
            }

        }
    }

}
