using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerConsole.ProgramTypology
{
    public class WatchDog : NetProgram, ITicker
    {


        public WatchDog(string name, int mU, int programStrength, Area area, NetSystem mySystem,Deck deck) : base(name, mU, programStrength, area, mySystem,deck)
        {
            Name = name;
            MU = mU;
            Program.TimePasses += Tick;
        }

        ~WatchDog()
        {
            Program.TimePasses -= Tick;

        }

        public void Tick() {

            if (Derezzed) {
                return;
            }
            if (Area.Entities.Any(x=> x.Team != Team) && CoolDown<= 0)
            {
                Activate();
            }
            else
            {
                CoolDown--;
                if (Player.inst.Area == Area)
                {
                    Console.WriteLine("Dog is unperturbed " + CoolDown);
                } 
            }
        }
        public override void Activate()
        {
            string res = "";

            foreach (var item in Area.Entities.Where(x => x.Team != Team))
            {
                if (item is Player && DetectPlayer((Player)item, this))
                {
                    res += "Regina! Thou Art Found! Watch_Dog Locks on to you with dead canine eyes and starts barking!";
                    MySystem.Alerted = true;
                    res += "\n Alarms start blaring! The System knows you are here! Stealth is no longer an option";
                }
                else
                {
                    res += "Watch_Dog is not alerted for now. But it won't be long before it tries again";
                }
            }

            Console.WriteLine(res);

        }
    }

}
