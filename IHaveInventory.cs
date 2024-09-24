using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public interface IHaveInventory //interface implemented in bag and player class to help with finding bags in inventory
    {
        Game_Object Locate(string id);
        
        string Name
        {
            get;

        }
        
    }
}
