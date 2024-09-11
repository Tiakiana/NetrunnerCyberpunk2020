using System.Reflection.Metadata.Ecma335;

namespace NetrunnerConsole
{
    public class GameManager
    {
        public static GameManager inst
        {
            get
            {
                if (_inst == null)
                {
                    _inst = new GameManager();
                }

                return _inst;
            }
        }
                
                
                private static GameManager _inst;
            
        public GameManager() {
            
        }

        public string EntityEnterHandler(Entity enter, Area area)
        {
            string res = "";

            foreach (var item in area.Entities)
            {
                if (item.Name == "Watch_Dog")
                {
                    NetProgram prog = item as NetProgram;
                   prog.Activate();
                }
            }
            return res;

        }

    }
}


