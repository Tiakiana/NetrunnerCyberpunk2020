using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerConsole.ProgramTypology
{
    public class Killer : NetProgram
    {
        public Killer(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck) : base(name, mU, programStrength, area, mySystem, deck)
        {

        }
        public override void Activate()
        {
            Console.WriteLine(Name + " gleams in your hand, ready to destroy!");
            NetProgram program = Program.ChooseEnemyProgram();
            int attackroll = RNG.Dee10();
            int defendroll = RNG.Dee10();
            Console.WriteLine(  $"{ Name} flies towards it's target {attackroll} + {ProgramStrength}]");
            Console.WriteLine(  $"{ program.Name} tries to defend {defendroll} + {program.ProgramStrength}]");

            if (attackroll+ProgramStrength>= defendroll+program.ProgramStrength)
            {
                int damage = RNG.Dee6();

            Console.WriteLine(  $"{ Name} strikes true! {damage} is inflicted");
                program.ProgramStrength -= damage;
                if (program.Derezzed)
                {
                    program.Name += "(Derezzed)";
                    program.DeRezz();

                }

            }
            else
            {
                Console.WriteLine("A Narrow Miss");
            }

        }

    }
}
