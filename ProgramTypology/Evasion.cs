using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerConsole.ProgramTypology
{
    public class Evasion : NetProgram
    {
        public Evasion(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck) : base(name, mU, programStrength, area, mySystem, deck)
        {

        }

        public override void Activate()
        {
            if (!Player.inst.ActivePrograms.Contains(this))
            {
            Player.inst.ActivePrograms.Add(this);
            }
            Console.WriteLine("A shimmer of benign static noise, that let's you hide your presence, surrounds you like a blizzard. You feel invisible!");
        }
    }
}
