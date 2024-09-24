using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public abstract class Command : Identifiable_Object //abstract class of all commands
    {
        public Command(List<string> ids) : base(ids)
        {

        }

        public abstract string Execute(Player p, List<string> text);


    }
}
