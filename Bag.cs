using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Case_Study
{
    public class Bag : Item , IHaveInventory //a type of item that can contain other items including another bag
    {
        private Inventory _inventory;
        private string _name;
        private string _description;

        public Bag(List<string> ids, string name, string desc) : base(ids, name, desc) 
        {
            _inventory = new Inventory();
            _name = name;
            _description = desc;

        }

        public Game_Object Locate(string id) //find an item in its inventory and return it
        {
            if (this.AreYou(id))
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(id);
            }
        }

        public override string FullDescription //return its name and a list of item
        {
            get
            {
                return "In the" + " " + _name + " " + "you can see:" + _inventory.ItemList;
            }
        }

        public void Put(Item itm)
        {
            _inventory.Put(itm);
        }

        public void Take(string itm)
        {
            _inventory.Take(itm);
        }

        public string Inventory
        {
            get
            {
                return _inventory.ItemList;
            }
        }



    }
}
