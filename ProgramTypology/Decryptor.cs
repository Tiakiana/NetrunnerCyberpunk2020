using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerConsole.ProgramTypology
{
    public class Decryptor : NetProgram
    {
        public Decryptor(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck) : base(name, mU, programStrength, area, mySystem, deck)
        {
        }

        public override void Activate()
        {
            Console.WriteLine("The Wizard's Book is called forth, and flips to the relevant page.");


            Console.WriteLine("Choose target type:");
            Console.WriteLine("1: Gates");
            Console.WriteLine("2: Files");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Gate gate = Program.ChooseGate();

                this.ProgramStrength = 6;
                DecryptGate(this, gate);
                this.ProgramStrength = 4;
            }
            else
            {
                if (!Player.inst.Area.Entities.Any(x => x is NetFile))
                {
                    Console.WriteLine("The book rumbles: NO SUCH FILES FOUND!");
                    Console.WriteLine("The Wizard's Book slams shut and returns to your deck.");
                    return;
                }

                NetFile netFile = Program.ChoseFile(Player.inst.Area);

                DecryptProgram(this, netFile);
            }

            Console.WriteLine("The Wizard's Book slams shut and returns to your deck.");
            // return "The Wizard's Book closes and returns to your deck.";

        }


    }
}
