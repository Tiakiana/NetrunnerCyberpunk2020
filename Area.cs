namespace NetrunnerConsole
{
    public class Area
    {
        public string Name;
        public List<Gate> Gates = new List<Gate>();
        public List<Entity> Entities = new List<Entity>();

        public delegate string EntityEnterArea(Entity entity, Area area);
        public event EntityEnterArea OnEntityEnter;


        
        public Area(string name)
        {
            Name = name;
            OnEntityEnter += GameManager.inst.EntityEnterHandler;
        }
        public string Scan(Player player)
        {
            
            string entityinfo = "";

            foreach (Entity e in Entities)
            {

                if (e is NetProgram)
                {
                    NetProgram ex = e as NetProgram;
                    int scanattempt = player.ScanningAttempt();
                    int scandefence = ex.ScanDefence();
                    if (scanattempt >= scandefence)
                    {
                        entityinfo = "Scanned: " + ex.Name + "\n";

                    }
                }

            }

            return ToString() + entityinfo;

        }

        public override string ToString()
        {
            string options = "";
            for (int i = 0; i < Gates.Count; i++)
            {

                options += Gates[i].GateName + "\n";
                if ((i + 1) < Gates.Count)
                {
                    options += "and ";
                }
            }


            return $"{Name}.\nFrom here there is \n\n {options} \n";
        }
        public void Transition(Entity entity)
        {
            OnEntityEnter.Invoke(entity,this);
        }
    }
}


