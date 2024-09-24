using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public class Item : Game_Object
    {
        public Item(List<string> idents, string name, string desc) : base(idents, name, desc) { }
    }
}
