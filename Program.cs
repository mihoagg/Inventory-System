using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Case_Study.Inventory;

namespace Case_Study;

public class Mainclass
{ 

    
    


    public static void Main()
    {
        Console.WriteLine("What is your name");
        string playerName = Console.ReadLine();
        Console.WriteLine("What is your description");
        string playerDesc = Console.ReadLine();

        Player p = new Player(playerName,playerDesc);

        Item Gem = new Item(new List<string> { "Gem"},"gem","a gem");
        Item Shovel = new Item(new List<string> { "Shovel" }, "shovel", "a shovel");

        p.Put(Gem);
        p.Put(Shovel);

        Bag Backpack = new Bag(new List<string> { "Backpack" }, "Backpack", "a backpack");
        p.Put(Backpack);

        Item Sword = new Item(new List<string> { "Sword" }, "sword", "a sword");
        Backpack.Put(Sword);

        while (true)
        {
            string Input = Console.ReadLine();
            List<string> InputList = new List<string>();
            string[] SplittedInput = Input.Split(' ');
            foreach (string s in SplittedInput)
            {
                InputList.Add(s);
            }
            LookCommand Look = new LookCommand(InputList);
            Console.WriteLine(Look.Execute(p, InputList));
        }


    }
}
