using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerConsole
{
    public class LDLManager
    {
        public Dictionary<string, LDLNode> Interwebs = new Dictionary<string, LDLNode>();


        public LDLNode LogonPoint;

        public LDLManager()
        {
            Player.inst.OnLogOff += SendRechnung;
            Program.TimePasses += Tally;

            //World Map
            addNode("Ascension", 2, 3, 10, 4);
            addNode("Atlanta", 2, 3, 6, 7);
            addNode("Berlin", 3, 3, 11, 8);
            addNode("Bogota", 1, 4, 6, 5);
            addNode("Buenos Aires", 2, 3, 7, 2);
            addNode("Cairo", 4, 4, 12, 6);
            addNode("Chicago", 2, 2, 6, 7);
            addNode("Crystal Palace", 2, 3, 11, 10); // Orbital Ville
            addNode("Dakar", 2, 2, 9, 6);
            addNode("Denver", 2, 1, 5, 7);
            addNode("Delhi", 1, 2, 14, 6);
            addNode("Havana", 2, 3, 6, 6);
            addNode("Honolulu", 2, 2, 1, 5);
            addNode("Hong Kong", 2, 3, 17, 6);
            addNode("Luna", 2, 4, 9, 12); // Orbital Ville
            addNode("London", 3, 2, 10, 8);
            addNode("Los Angeles", 2, 2, 4, 6);
            addNode("Madrid", 3, 2, 10, 7);
            addNode("Melbourne", 2, 2, 18, 1);
            addNode("Mexico City", 1, 2, 4, 6);
            addNode("Montreál", 2, 2, 6, 8);
            addNode("Moscow", 3, 2, 13, 8);
            addNode("New Orleans", 2, 3, 5, 6);
            addNode("New York / BosWash", 3, 1, 6, 7);
            addNode("Nairobi", 2, 2, 12, 4);
            addNode("Night City", 2, 2, 4, 7);
            addNode("Panama City", 1, 3, 6, 5);
            addNode("Paris", 3, 2, 10, 8);
            addNode("Beijing", 3, 2, 17, 7);
            addNode("Rio De Janiero", 2, 2, 8, 3);
            addNode("Rome", 2, 2, 11, 7);
            addNode("Salt Lake", 2, 1, 4, 7);
            addNode("San Francisco", 2, 2, 4, 7);
            addNode("Seattle", 2, 2, 3, 8);
            addNode("Stockholm", 3, 2, 11, 9);
            addNode("Tokyo", 3, 2, 18, 6);


            // City map
            addNode("Uniboard", 1, 0, 2, 4);
            addNode("Night City U", 0, 0, 3, 2);
            addNode("Big Black", 4, 0, 4, 7);
            addNode("Metalhed", 0, 0, 8, 13);
            addNode("EBM", 4, 0, 8, 5);
            addNode("Net 54", 1, 0, 8, 4);
            addNode("TechTalk BBS", 1, 0, 8, 2);
            addNode("Microtech", 3, 0, 9, 7);
            addNode("InfoComp", 3, 0, 9, 5);
            addNode("Boogie Board", 0, 0, 10, 11);
            addNode("PetroChem", 4, 0, 10, 6);
            addNode("Arasaka", 4, 0, 12, 7);
            addNode("Merrill, Asukaga & Finch", 2, 0, 12, 4);
            addNode("City Hall", 0, 0, 13, 10);
            addNode("WHS", 1, 0, 13, 6);
            addNode("Oribtal Air", 3, 0, 13, 5);
            addNode("Hall of Justice", 1, 0, 14, 10);
            addNode("Internet Phone", 0, 0, 15, 11);
            addNode("Eurobank", 4, 0, 15, 8);
            addNode("WorldSat", 2, 0, 15, 5);
            addNode("Trauma Team", 1, 0, 16, 6);
            addNode("City Medical", 0, 0, 17, 6);
            addNode("Medical Technologies", 0, 0, 17, 5);
            addNode("Dark Angles", 4, 0, 17, 2);
            addNode("Virtual Mall", 0, 0, 20, 5);
        }
        private void addNode(string name, int security, int traceValue, int xPos, int yPos)
        {
            Interwebs.Add(name, new LDLNode(name, security, traceValue, xPos, yPos));
        }

        public List<LDLNode> GetWithinReach(LDLNode node)
        {
            List<LDLNode> res = new List<LDLNode>();
            foreach (string node2 in Interwebs.Keys)
            {
                if (distance(node, Interwebs[node2]) <= 5)
                {
                    res.Add(Interwebs[node2]);
                }
            }
            return res;
        }

        public void Crack(LDLNode node)
        {
            if (RNG.D10 <= node.SecurityLvl)
            {
                int roll = RNG.D6;
                Console.WriteLine("Alert has been raised! though art fat and noisy!");
                Console.WriteLine("Rolling to see what happens!");
                Console.WriteLine("Rolling 1d6: " + roll);
                switch (roll)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Tally();
                        Console.WriteLine("You are cut off and billed: " + money);
                        break;

                    case 5:
                        Console.WriteLine("Piss and blood, Your Majesty! Netwatch has beeen given your home address. Expect their knaves to arrive within 1-6 business days!");
                        break;
                    case 6:
                        int reroll = RNG.D6;
                        switch (reroll)
                        {
                            case 1:
                            case 2:
                                Console.WriteLine("The knaves of NetWatch fine you for " + RNG.D6 * 100 + "ed.");
                                break;
                            case 3:
                            case 4:
                            case 5:
                                Console.WriteLine("You escape, but the NetWatch knaves will be here for at least " + (RNG.D6 + 1) + " days, patrolling. They HOPE thou revisitest them!");
                                break;
                            case 6:
                                Console.WriteLine("Thou have escaped Netwatch's grasp, but not their attention! An All Net Bulletin has been staked on your IP, ICON and Handle. Darn it all to hell, your majesty");
                                break;
                            default:
                                break;
                        }

                        break;
                    default:
                        break;
                }

            }
            else
            {
                Player.inst.Connections.Add(node);
            }
        }
        float money = 0;
        public void Tally()
        {
            List<LDLNode> nodes = Player.inst.Connections.Where(x => x.Legal).ToList();
            if (nodes.Count > 1)
            {
                for (int i = 0; i < nodes.Count - 1; i++)
                {

                    money += 0.2f * distance(nodes[i], nodes[i + 1]);
                }
            }

        }
        public void SendRechnung()
        {
            Console.WriteLine("Total creds owed for Long distance linkage: " + money + " ED.");
            money = 0;


        }



        int distance(LDLNode a, LDLNode b)
        {
            return Math.Abs(a.Xpos - b.Xpos) + Math.Abs(a.Ypos - b.Ypos);
        }
    }

    public class LDLNode
    {
        public string Name;
        public int SecurityLvl;
        public int TraceValue;
        public int Xpos, Ypos;
        public bool Legal = false;

        public LDLNode(string name, int seclvl, int traceValue, int xpos, int ypos)
        {
            Name = name;
            SecurityLvl = seclvl;
            TraceValue = traceValue;
            Xpos = xpos;
            Ypos = ypos;
        }
    }

}

