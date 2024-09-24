using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public abstract class Game_Object : Identifiable_Object //abstract class of all game objects
    {
        private string _description;
        private string _name;
        

        public Game_Object(List<string> ids, string name, string desc) : base(ids) 
        {
            _description = desc;
            _name = name;
            
           
        }

        public  string Name
        {
            get
            {
                return _name;
            }
        } 


       


        public string ShortDescription //returns name of the object and its first id
        {
            get
            {
                return "a" + " " + _name + " " + "(" + this.FirstId.ToString() + ")";
            }
        }


        public virtual string FullDescription //returns full description of the object
        {
            get
            {
                return _description;
            }
        }


    }
}
