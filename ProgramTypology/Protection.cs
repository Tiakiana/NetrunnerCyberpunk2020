using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerConsole.ProgramTypology
{
    public class Protection : NetProgram
    {
        public Protection(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck) : base(name, mU, programStrength, area, mySystem, deck)
        {
            ProgramType = ProgramType.Protection;
        }

        public override void Activate()
        {
            Console.WriteLine("The protective forcefield wells up in front of you. You feel safer!");
            if (!Player.inst.ActivePrograms.Contains(this))
            {
            Player.inst.ActivePrograms.Add(this);
            }

        }

    }
}
