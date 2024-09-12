using System.ComponentModel;

namespace NetrunnerConsole
{
    public class Gate
    {
        public string GateName;
        public Area OutSide, Inside;
        public int GateStrength;
        public int Team;
        public bool Broken = false;

        public Gate(Area outSide, Area inside, int gateStrength, int team)
        {
            GateName = "a " + (Broken ? " broken" : "") + (gateStrength == 0 ? "passage from " : "gate from ") + outSide.Name + " to " + inside.Name;
            Inside = inside;
            inside.Gates.Add(this);
            OutSide = outSide;
            outSide.Gates.Add(this);
            GateStrength = gateStrength;
            Team = team;
        }

        public string GetName(Area area)
        {
            if (OutSide == area ||Inside == area)
            {
                return $"a {(Broken ? " broken " : "") + (GateStrength == 0 ? "passage leading to" : "gate leading to")} {(Inside==area?OutSide.Name:Inside.Name)}";
            }
            return "Not available door";
        }

        public string GetAreaName(Area area)
        {
            if (OutSide == area || Inside == area)
            {
                return $"{(Inside == area ? OutSide.Name : Inside.Name)}";
            }
            return "Not available door";
        }


        public void Transition(Entity entity)
        {
            if (entity.Team == Team || Broken || GateStrength == 0)
            {
                if (entity.Area == OutSide)
                {
                    entity.Area = Inside;
                    OutSide.Entities.Remove(entity);
                    Inside.Entities.Add(entity);
                    Inside.Transition(entity);
                }
                else if (entity.Area == Inside)
                {
                    entity.Area = OutSide;
                    Inside.Entities.Remove(entity);
                    OutSide.Entities.Add(entity);
                    OutSide.Transition(entity);

                }
            }
            else { Console.WriteLine("It's locked! You cannot Get through " + GateName + " It's strength is " + GateStrength); }
        }
    }
}


