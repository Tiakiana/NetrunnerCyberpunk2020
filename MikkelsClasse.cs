namespace NetrunnerConsole
{
    public class MikkelsClasse
    {
            static void Main2(string[] args)
            {
                bool showMenu = true;
                while (showMenu)
                {
                    showMenu = MainMenu();
                }
            }
            private static bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Run Program");
                Console.WriteLine("2) Scan");
                Console.WriteLine("3) Long Distance Link");
                Console.WriteLine("4) Copy");
                Console.WriteLine("5) Erase");
                Console.WriteLine("6) Read");
                Console.WriteLine("7) Edit");
                Console.WriteLine("8) Create");
                Console.WriteLine("9) Delete");
                Console.WriteLine("10) Log Off");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        RunProgram();
                        return true;
                    case "2":
                        Scan();
                        return true;
                    case "3":
                        LongDistanceLink();
                        return true;
                    case "4":
                        Copy();
                        return true;
                    case "5":
                        Erase();
                        return true;
                    case "6":
                        Read();
                        return true;
                    case "7":
                        Edit();
                        return true;
                    case "8":
                        Create();
                        return true;
                    case "9":
                        Delete();
                        return true;
                    case "10":
                        LogOff();
                        return false;
                    default:
                        return true;
                }
            }
            private static string RunProgram()
            {
                Console.Clear();
                Console.WriteLine("Choose the program category you would like to run: ");
                Console.WriteLine("1) Intrusion (Programs to destroy Datawalls)");
                Console.WriteLine("2) Decryption (Programs to disable Codegates/Filelocks)");
                Console.WriteLine("3) Detection/Alarm (Programs for spotting and information gathering)");
                Console.WriteLine("4) Anti System (Programs that attack the Deck/CPU)");
                Console.WriteLine("5) Evasion/Stealth (Programs to hide with)");
                Console.WriteLine("6) Protection (Programs to keep you alive)");
                Console.WriteLine("7) Anti-IC (Programs that attack PROGRAMS)");
                Console.WriteLine("8) Anti-Personnel (Programs that can kill Netrunners)");
                Console.WriteLine("9) Controllers (Programs that can control hardware)");
                Console.WriteLine("10) Utillities (Programs that do certain tasks)");
                Console.WriteLine("11) Demons (Programs that can carry a set of programs)");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Choose the program you would like to run: ");
                        Console.WriteLine("1) Hammer - Knocks down datawalls (2d6 per attack to data wall Strength) - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("2) Jackhammer - Knocks down datawalls (1d6 per attack to data wall Strength) - STR 2 - MU 2 -CS 360€");
                        Console.WriteLine("3) Worm - Infiltrates and breaks down datawalls silently in 2 turns - STR 2 - MU 5 -CS 660€");
                        Console.WriteLine("4) Return");
                        Console.Write("\r\nSelect an option: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Hammer");
                                //You have decided to use Hammer and Arndal will now make it work
                                break;
                            case "2":
                                Console.WriteLine("Jackhammer");
                                //You have decided to use Jackhammer and Arndal will now make it work
                                break;
                            case "3":
                                Console.WriteLine("Worm");
                                //You have decided to use Worm and Arndal will now make it work
                                break;
                            case "4":
                                RunProgram();
                                break;
                            default:
                                break;
                        }
                        return Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Choose the program you would like to run: ");
                        Console.WriteLine("1) Code Cracker - Breaks down code gates and file locks - STR 3 - MU 2 -CS 380€");
                        Console.WriteLine("2) Wizard's Book - Deciphers code gates (STR 6) & file locks - STR 4/6 - MU 2 -CS 400€");
                        Console.WriteLine("3) Raffles - Deciphers code gates & file locks - STR 5 - MU 3 -CS 560€");
                        Console.WriteLine("4) Return");
                        Console.Write("\r\nSelect an option: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Code Cracker");
                                //You have decided to use Code Cracker and Arndal will now make it work
                                break;
                            case "2":
                                Console.WriteLine("Wizard's Book");
                                //You have decided to use Wizard's Book and Arndal will now make it work
                                break;
                            case "3":
                                Console.WriteLine("Raffles");
                                //You have decided to use Raffles and Arndal will now make it work
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Choose the program you would like to run: ");
                        Console.WriteLine("1) Watchdog - Detects entry and alerts owner - STR 4 - MU 5 -CS 610€");
                        Console.WriteLine("2) Bloodhound - Detects entry and traces signal, then alerts master - STR 3 - MU 5 -CS 700€");
                        Console.WriteLine("3) Pit Bull - Detects entry, traces signal and cuts intruder's line until killed - STR 2 - MU 6 -CS 780€");
                        Console.WriteLine("4) SeeYa - Detects 'Invisible' ICONS - STR 3 - MU 1 -CS 280€");
                        Console.WriteLine("5) Hidden Virtue - Detecs 'real' things in virtual realities - STR 3 - MU 1 -CS 280€");
                        Console.WriteLine("6) Speedtrap - Detects hidden programming within 10 spaces - STR 4 - MU 4 -CS 600€");
                        Console.WriteLine("7) Return");
                        Console.Write("\r\nSelect an option: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Watchdog");
                                //You have decided to use Watchdog and Arndal will now make it work
                                break;
                            case "2":
                                Console.WriteLine("Bloodhound");
                                //You have decided to use Bloodhound and Arndal will now make it work
                                break;
                            case "3":
                                Console.WriteLine("Pit Bull");
                                //You have decided to use Pit Bull and Arndal will now make it work
                                break;
                            case "4":
                                Console.WriteLine("SeeYa");
                                //You have decided to use SeeYa and Arndal will now make it work
                                break;
                            case "5":
                                Console.WriteLine("Hidden Virtue");
                                //You have decided to use Hidden Virtue and Arndal will now make it work
                                break;
                            case "6":
                                Console.WriteLine("Speedtrap");
                                //You have decided to use Speedtrap and Arndal will now make it work
                                break;
                            case "7":
                                Console.WriteLine("Return");
                                //You have decided to use Pit Bull and Arndal will now make it work
                                break;
                            default:
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Choose the program you would like to run: ");
                        Console.WriteLine("1) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("2) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("3) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("4) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("5) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("6) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("7) Return");
                        Console.Write("\r\nSelect an option: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Hammer");
                                //You have decided to use Hammer and Arndal will now make it work
                                break;
                            case "2":
                                Console.WriteLine("Jackhammer");
                                //You have decided to use Jackhammer and Arndal will now make it work
                                break;
                            case "3":
                                Console.WriteLine("Worm");
                                //You have decided to use Worm and Arndal will now make it work
                                break;
                            default:
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Choose the program you would like to run: ");
                        Console.WriteLine("1) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("2) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("3) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("4) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("5) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("6) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("7) Return");
                        Console.Write("\r\nSelect an option: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Hammer");
                                //You have decided to use Hammer and Arndal will now make it work
                                break;
                            case "2":
                                Console.WriteLine("Jackhammer");
                                //You have decided to use Jackhammer and Arndal will now make it work
                                break;
                            case "3":
                                Console.WriteLine("Worm");
                                //You have decided to use Worm and Arndal will now make it work
                                break;
                            default:
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Choose the program you would like to run: ");
                        Console.WriteLine("1) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("2) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("3) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("4) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("5) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("6) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("7) Return");
                        Console.Write("\r\nSelect an option: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Hammer");
                                //You have decided to use Hammer and Arndal will now make it work
                                break;
                            case "2":
                                Console.WriteLine("Jackhammer");
                                //You have decided to use Jackhammer and Arndal will now make it work
                                break;
                            case "3":
                                Console.WriteLine("Worm");
                                //You have decided to use Worm and Arndal will now make it work
                                break;
                            default:
                                break;
                        }
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Choose the program you would like to run: ");
                        Console.WriteLine("1) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("2) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("3) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("4) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("5) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("6) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("7) Return");
                        Console.Write("\r\nSelect an option: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Hammer");
                                //You have decided to use Hammer and Arndal will now make it work
                                break;
                            case "2":
                                Console.WriteLine("Jackhammer");
                                //You have decided to use Jackhammer and Arndal will now make it work
                                break;
                            case "3":
                                Console.WriteLine("Worm");
                                //You have decided to use Worm and Arndal will now make it work
                                break;
                            default:
                                break;
                        }
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Choose the program you would like to run: ");
                        Console.WriteLine("1) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("2) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("3) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("4) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("5) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("6) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("7) Return");
                        Console.Write("\r\nSelect an option: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Hammer");
                                //You have decided to use Hammer and Arndal will now make it work
                                break;
                            case "2":
                                Console.WriteLine("Jackhammer");
                                //You have decided to use Jackhammer and Arndal will now make it work
                                break;
                            case "3":
                                Console.WriteLine("Worm");
                                //You have decided to use Worm and Arndal will now make it work
                                break;
                            default:
                                break;
                        }
                        break;
                    case "9":
                        Console.Clear();
                        Console.WriteLine("Choose the program you would like to run: ");
                        Console.WriteLine("1) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("2) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("3) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("4) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("5) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("6) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("7) Return");
                        Console.Write("\r\nSelect an option: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Hammer");
                                //You have decided to use Hammer and Arndal will now make it work
                                break;
                            case "2":
                                Console.WriteLine("Jackhammer");
                                //You have decided to use Jackhammer and Arndal will now make it work
                                break;
                            case "3":
                                Console.WriteLine("Worm");
                                //You have decided to use Worm and Arndal will now make it work
                                break;
                            default:
                                break;
                        }
                        break;
                    case "10":
                        Console.Clear();
                        Console.WriteLine("Choose the program you would like to run: ");
                        Console.WriteLine("1) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("2) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("3) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("4) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("5) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("6) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("7) Return");
                        Console.Write("\r\nSelect an option: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Hammer");
                                //You have decided to use Hammer and Arndal will now make it work
                                break;
                            case "2":
                                Console.WriteLine("Jackhammer");
                                //You have decided to use Jackhammer and Arndal will now make it work
                                break;
                            case "3":
                                Console.WriteLine("Worm");
                                //You have decided to use Worm and Arndal will now make it work
                                break;
                            default:
                                break;
                        }
                        break;
                    case "11":
                        Console.Clear();
                        Console.WriteLine("Choose the program you would like to run: ");
                        Console.WriteLine("1) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("2) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("3) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("4) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("5) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("6) a - b - STR 4 - MU 1 -CS 400€");
                        Console.WriteLine("7) Return");
                        Console.Write("\r\nSelect an option: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Hammer");
                                //You have decided to use Hammer and Arndal will now make it work
                                break;
                            case "2":
                                Console.WriteLine("Jackhammer");
                                //You have decided to use Jackhammer and Arndal will now make it work
                                break;
                            case "3":
                                Console.WriteLine("Worm");
                                //You have decided to use Worm and Arndal will now make it work
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }
                return Console.ReadLine();
            }


            private static string Scan()
            {
                Console.Write("Scan");
                return Console.ReadLine();
            }

            private static string LongDistanceLink()
            {
                Console.Write("LongDistanceLink");
                return Console.ReadLine();
            }

            private static string Copy()
            {
                Console.Write("Copy");
                return Console.ReadLine();
            }

            private static string Erase()
            {
                Console.Write("Erase");
                return Console.ReadLine();
            }

            private static string Read()
            {
                Console.Write("Read");
                return Console.ReadLine();
            }

            private static string Edit()
            {
                Console.Write("Edit");
                return Console.ReadLine();
            }

            private static string Create()
            {
                Console.Write("Create");
                return Console.ReadLine();
            }

            private static string Delete()
            {
                Console.Write("Delete");
                return Console.ReadLine();
            }
            private static string LogOff()
            {
                Console.Write("LogOff");
                return Console.ReadLine();
            }
        }
    
}