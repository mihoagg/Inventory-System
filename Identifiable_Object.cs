using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public class Identifiable_Object //parent class of all classes
    {
        private List<string> _identifiers;


        public Identifiable_Object(List<string> idents) 
        {
            _identifiers = idents; //string array of indentifiers
        }

        

        public bool AreYou(string t) //identify the object
        {
            if (_identifiers.Contains(t))
            {
                return true;
            }
            else { return false; }
        }

        public string FirstId //returns first identifier
        {
            get
            {
                
                if (_identifiers.Count == 0)
                {
                    return "";
                }
                else return _identifiers[0].ToString();
                
            }
        }

        public void AddIdentifier(string t) 
        {
            _identifiers.Add(t.ToLower());
        }
            
   
       
        public string Test()
        {

            return _identifiers[1].ToString();
        }
    }
}
