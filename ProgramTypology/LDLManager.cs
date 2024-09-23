using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerConsole {
    public class LDLManager 
    {
        public Dictionary<string, LDLNode> Interwebs = new Dictionary<string, LDLNode>();


        public LDLNode LogonPoint;

        public LDLManager()
        {
            Player.inst.OnLogOff += SendRechnung;
            Program.TimePasses += Tally;
            
            //skal udfyldes
            Interwebs.Add("Night City", new LDLNode("Night City",2,2,4,7));
            Interwebs.Add("New York City", new LDLNode("New York City",2,2,6,7));





        }


        public List<LDLNode> GetWithinReach(LDLNode node)
        {
            List<LDLNode> res = new List<LDLNode>();
            foreach (string node2 in Interwebs.Keys)
            {
                if (distance(node, Interwebs[node2])<=5)
                {
                    res.Add(Interwebs[node2]);
                }
            }
            return res;
        }

        public void Crack(LDLNode node)
        {
            if (RNG.D10<=node.SecurityLvl)
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
                        Console.WriteLine("You are cut off and billed: " +money);
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
                                Console.WriteLine("The knaves of NetWatch fine you for " + RNG.D6*100 +"ed.");
                                break;
                            case 3:
                            case 4:
                            case 5:
                                Console.WriteLine("You escape, but the NetWatch knaves will be here for at least " + (RNG.D6+1) +" days, patrolling. They HOPE thou revisitest them!");
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
            List<LDLNode> nodes = Player.inst.Connections.Where(x=> x.Legal).ToList() ;
            if (nodes.Count>1)
            {
                for (int i = 0; i < nodes.Count-1; i++)
                {

                    money += 0.2f * distance(nodes[i], nodes[i + 1]);
                }
            }
            
        }
        public void SendRechnung()
        {
            Console.WriteLine("Total creds owned for Long distance linkage: " + money +" ED.");
            money = 0;


        }



        int distance(LDLNode a, LDLNode b)
        {
            return  Math.Abs(a.Xpos - b.Xpos) + Math.Abs(a.Ypos-b.Ypos);
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

