using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerConsole.ProgramTypology
{
    public class NetFile : NetProgram
    {
        public string Content;
        public NetFile(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck,string content) : base(name, mU, programStrength, area, mySystem, deck)
        {
            Content = content;
            Encrypted = true;
        }
        public string Read()
        {
            if (Encrypted)
            {
                return "The file is locked. The mysteries of " + Name + " will remain just that: a mystery";
            }
            return Content;
        }

    }
}
