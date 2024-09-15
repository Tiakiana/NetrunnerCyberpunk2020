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

            int rollattacker = RNG.Dee10();
            int rolldefender = RNG.Dee10();
            List<NetProgram> protections = Player.inst.ActivePrograms.Where(x => x.ProgramType == ProgramType.Protection).ToList();
            int strength = (protections.Count > 0 ? protections.Max(x => x.ProgramStrength) : 0) + Player.inst.InterfaceStrength + Player.inst.Intelligence;
            Console.WriteLine($"The Stun is zapped at you, {Player.inst.Name}; [{rollattacker + 10 + MySystem.Intelligence + ProgramStrength}]");
            Console.WriteLine($"You defend yourself [(roll){rolldefender} + (protection) {strength} + (interface) {Player.inst.InterfaceStrength} + (int) {Player.inst.Intelligence}]");

            if (rollattacker + ProgramStrength + MySystem.Intelligence + 10 >= rolldefender + strength + Player.inst.Intelligence + Player.inst.InterfaceStrength)
            {
                int roll = RNG.Dee6();

                if (Player.inst.Stun > roll)
                {
                    roll = Player.inst.Stun;
                }
                Player.inst.Stun = roll;
                Console.WriteLine($", but to no avail! You are stunned for {roll} turns!");
            }
            else
            {
                Console.WriteLine($", and with ease you avoid the attack");
            }
            

        }
    }

}
