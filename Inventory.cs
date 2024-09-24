using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    
    public class Inventory
    {
        


        private List<Item> _items;



        public Inventory() 
        {
            _items = new List<Item>(); //list of item class that inventory contains
        }

        public bool HasItem(string id) //returns true if contains given item
        {
            
            foreach (Item itm in _items)
            {
                if (itm.AreYou(id))
                {
                    return true;
                }
            }
            return false;
        }
          
        
         
        public void Put(Item itm) 
        {
            _items.Add(itm);
        }


        public Item Fetch(string id) //find item in inventory and return it
        {
            Item i = null;
            foreach (Item itm in _items)
            {
                
                if (itm.AreYou(id))
                {
                    
                    i = itm;
                    break;

                }

                
                
                
            }
            return i;



        }

        public Item Take(string id) //find item in inventory and return and remove it
        {
            Item i = null;
            foreach (Item itm in _items)
            {
                if (itm.AreYou(id))
                {
                    i = itm;
                    _items.Remove(itm);
                    break;
                }

            }
            return i;
        }


        public string ItemList //return a list of short description of all items in inventory
        {
            get
            {
                List<string> list = new List<string>();
                foreach (Item itm in _items)
                {
                    list.Add(itm.ShortDescription);
                }

                string result = "";
                int i = 0;
                while (i < list.Count)
                {
                    result = result + "    " + list[i] + "\n";
                    i++;
                }

                return result;
                    
            }
        }




















    }
}
