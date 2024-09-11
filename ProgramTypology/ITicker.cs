using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerConsole.ProgramTypology
{
    public interface ITicker
    {
        public int CoolDown { get; set; }
        public void Tick()
        {
            CoolDown -= 1; if (CoolDown<0)
            {
                CoolDown = 0;
            } }

    }
}
