using NetrunnerConsole.ProgramTypology;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace NetrunnerConsole
{
    internal class Program
    {
        public Player Player = new Player("Regina");
        public NetSystem System = new NetSystem();

        public GameManager GameManager = new GameManager();


        static void Main(string[] args)
        {
            Console.ForegroundColor
        = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("All Hail the Majestic Regina! How can thy serfs help thee?");

            Program p = new Program();
            p.Player.CurrentDeckEquipped = new Deck();
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateWizardsBook(p.Player.CurrentDeckEquipped));
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateInvisibility(p.Player.CurrentDeckEquipped));
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateStealth(p.Player.CurrentDeckEquipped));
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateForceProtection(p.Player.CurrentDeckEquipped));
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateKiller4(p.Player.CurrentDeckEquipped));

            p.Player.Area = p.System.Areas[0];
            p.Player.Team = 3;
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Your Command, thy Majesty?");

                string res = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                res = res.ToUpper();
                switch (res)
                {
                    case "READ":
                        Console.Clear();

                        Console.WriteLine();
                        p.Read();
                        Console.WriteLine();
                        Console.WriteLine();

                        break;
                    case "SCAN":
                        Console.Clear();

                        Console.WriteLine("Choose Where to Scan");
                        Area area = p.ChooseArea();
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine(area.Scan(p.Player));
                        Console.WriteLine();
                        Console.WriteLine();

                        break;
                    case "STATUS":
                        Console.Clear();

                        Console.WriteLine("\tThine active programs art:");
                        Console.WriteLine();
                        if (Player.inst.ActivePrograms.Count == 0)
                        {
                            Console.WriteLine(  "Naught and nothing");
                        }
                        else
                        {

                            foreach (var item in Player.inst.ActivePrograms)
                            {
                                Console.WriteLine(item.Name);
                            }
                        }



                        break;
                    case "MOVE":
                        Console.Clear();

                        Console.WriteLine("Choose where to go to");
                        ChooseGate().Transition(p.Player);
                        Console.WriteLine();
                        Console.WriteLine();


                        break;
                    case "HELP":

                        Console.WriteLine("");
                        Console.WriteLine("\t Available Commands: ");
                        Console.WriteLine();
                        Console.WriteLine("Scan");
                        Console.WriteLine("Run");
                        Console.WriteLine("Move");
                        Console.WriteLine("Look: scans your immediate surroundings");
                        Console.WriteLine("Read read a file in same area or in your deck.");
                        Console.WriteLine("Erase");
                        Console.WriteLine("Clear: *new*");
                        Console.WriteLine("Status: *new* Shows what programs are active on you :D");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                    case "RUN":
                        Console.Clear();

                        Console.WriteLine();

                        Console.WriteLine();
                        p.Run();
                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case "ERASE":
                        Console.Clear();

                        Console.WriteLine("Not yet implemented");

                        break;

                    case "LOOK":
                        Console.Clear();

                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("You look around.\nYou are at: ");
                        Console.WriteLine(p.Player.Area.Scan(p.Player));
                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case "":
                        Console.WriteLine("No input detected. Are you a moron?");
                        break;
                    case "CLEAR":
                        Console.Clear();
                        Console.WriteLine("Tidying up for Thee, Your Majesty");
                        break;
                }
            }
        }

        private void Read()
        {
            Console.WriteLine("What would you like to read?");

            NetFile file = ChoseFile(Player.inst.Area);

            Console.WriteLine(file.Read());
            //Todo let them Eat their own deck.

        }

        private void Run()
        {
            Console.WriteLine(  );
            Console.WriteLine(  );
            Console.WriteLine("What would you like to Run?");
            //enumerate all available programs!
            NetProgram programToRun = ChooseProgram();
            if (programToRun == null)
            {
                Console.WriteLine("Dammit, thou art fucked, Your Highness!");
                return;
            }
            programToRun.Activate();


        }

        private void Scan()
        {
            Console.WriteLine("What would you like to scan?");

            int choice = int.Parse(Console.ReadLine());

        }
        public static Gate ChooseGate()
        {
            Console.WriteLine();
            Console.WriteLine();

            for (int ix = 1; ix < Player.inst.Area.Gates.Count + 1; ix++)
            {
                // Console.WriteLine(ix + ": " + Player.inst.Area.Gates[ix - 1].GateName);
                Console.WriteLine(ix + ": " + (Player.inst.Area.Gates[ix - 1].GetName(Player.inst.Area)));
                // Player.Area.Gates[ix - 1].Inside == Player.Area ? Player.Area.Gates[ix-1].OutSide.Name: Player.Area.Gates[ix - 1].Inside.Name));

            }

            int res2 = int.Parse(Console.ReadLine());
            res2--;
            return Player.inst.Area.Gates[res2];
        }
        public static NetProgram ChooseEnemyProgram()
        {
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < Player.inst.Area.Entities.Count + 1; i++)
            {
                if (Player.inst.Area.Entities[i - 1] is Player)
                {
                    continue;
                }
                Console.WriteLine(i + ": " + Player.inst.Area.Entities[i - 1].ToString());
            }

            if (Player.inst.Area.Entities.Count == 0)
            {
                Console.WriteLine("No targets!");
                return null;
            }

            int res = int.Parse(Console.ReadLine());
            res--;
            return Player.inst.Area.Entities[res] as NetProgram;
        }
        private NetProgram ChooseProgram()
        {
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < Player.CurrentDeckEquipped.ProgramList.Count + 1; i++)
            {
                Console.WriteLine(i + ": " + Player.CurrentDeckEquipped.ProgramList[i - 1].ToString());
            }

            if (Player.CurrentDeckEquipped.ProgramList.Count == 0)
            {
                Console.WriteLine("No programs in deck!");
                return null;
            }

            int res = int.Parse(Console.ReadLine());
            res--;
            return Player.CurrentDeckEquipped.ProgramList[res];
        }
        public static NetFile ChoseFile(Area area)
        {

            for (int i = 1; i < area.Entities.Where(x => x is NetFile).Count() + 1; i++)
            {
                Console.WriteLine(i + ": " + area.Entities.Where(x => x is NetFile).ToList()[i - 1].ToString());
            }

            if (area.Entities.Where(x => x is NetFile).Count() == 0)
            {
                Console.WriteLine("No Files in area!");
                return null;
            }

            int res = int.Parse(Console.ReadLine());
            res--;
            return area.Entities.Where(x => x is NetFile).ToList()[res] as NetFile;
        }

        private Area ChooseArea()
        {
            for (int ix = 1; ix < Player.Area.Gates.Count + 1; ix++)
            {
                //     Console.WriteLine(ix + ": " + (Player.Area.Gates[ix - 1].Inside == Player.Area ? Player.Area.Gates[ix-1].OutSide.Name: Player.Area.Gates[ix - 1].Inside.Name));
                Console.WriteLine(ix + ": " + (Player.Area.Gates[ix - 1].GetAreaName(Player.Area)));// Player.Area.Gates[ix - 1].Inside == Player.Area ? Player.Area.Gates[ix-1].OutSide.Name: Player.Area.Gates[ix - 1].Inside.Name));

            }

            int res2 = int.Parse(Console.ReadLine());
            res2--;
            return Player.Area.Gates[res2].Inside == Player.Area ? Player.Area.Gates[res2].OutSide : Player.Area.Gates[res2].Inside;
        }

    }
}


