using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public class Player : Game_Object , IHaveInventory
    {
        private string _name;
        private string _description;
        private Inventory _inventory;
        public Player(string name, string desc) : base(new List<string> { "Me", "inventory" }, name, desc) 
        {
            _inventory = new Inventory();
            _description = desc;
            _name = name;
        }

        public Game_Object Locate(string id) //find the given item in inventory and returns it, can return the player itself
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

        public override string FullDescription //return name of player and list of items in inventory
        {
            get
            {
                return "You are" + " " + _name + ", " + _description + ". You are carrying:" + _inventory.ItemList;
            }
        }
        public string Inventory
        {
            get
            {
                return _inventory.ItemList;
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
        
       
        
    }
}
