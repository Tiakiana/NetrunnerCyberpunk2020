using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerConsole.ProgramTypology
{
    public class Flatline : NetProgram
    {
        public Flatline(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck) : base(name, mU, programStrength, area, mySystem, deck)
        {

        }

        public override void Activate()
        {

            int attack = RNG.D10;
            int defenceroll = RNG.D10;

            Console.WriteLine($"The Flatline prog beams towards you [(roll){attack} + (programstrength) {ProgramStrength}]" );
            Console.WriteLine($"You defend yourself as best you can! [(roll) {defenceroll} + (datawall strength) {Player.inst.CurrentDeckEquipped.DatawallStrength}"  );


            if (attack+ProgramStrength>= defenceroll+Player.inst.CurrentDeckEquipped.DatawallStrength)
            {
                Console.WriteLine("Your majesty! Our kingdom izzzz dduuuuuuuuuurr rrrrrrrr");

                Console.WriteLine("");
                Thread.Sleep(1000);
                Console.WriteLine(".......----.........");
                Thread.Sleep(1000);
                Console.WriteLine("HEEEEERP");
                Thread.Sleep(1000);
                Console.WriteLine("!#!%!%¤#%¤ /%¤/%&%&/%¤");
                Thread.Sleep(1000);

                Console.WriteLine("Interface Chip compromised, please install a new chip and type in serial number (4 character code)");

                string required = "JZK4";
                Player.inst.CurrentDeckEquipped.SerialNumberRequired = required;

            }

        }


    }

}
