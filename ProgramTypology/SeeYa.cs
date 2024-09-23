using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerConsole.ProgramTypology
{
    internal class SeeYa : NetProgram
    {
        public SeeYa(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck) : base(name, mU, programStrength, area, mySystem, deck)
        {

        }

        public override void Activate()
        {
            Console.WriteLine("A purple lens lends it's clarity to you:");

            foreach (var item in Player.inst.Area.Gates) {
                if (!item.Visible)
                {
                    Console.WriteLine("Aha! A " + item.GateName + " is revealed");
                    item.Visible = true;
                }
            
            }
            Console.WriteLine("The ring dissipates and returns to your deck");
        }
    }
}
