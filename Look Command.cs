using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Case_Study
{
    public class LookCommand : Command
    {
        //List<string> _ids;
        public LookCommand(List<string> ids) : base(ids) 
        {
            //_ids = ids;
        }

        private IHaveInventory FetchContainer(Player p, string containerId) //find a container in player's inventory
        {
            IHaveInventory container;
            container = p.Locate(containerId) as IHaveInventory;
            return container;
            
        }

        private string LookAtin (string thingId, IHaveInventory container) //find an item in a container
        {
            Game_Object Thing;
            Thing = container.Locate(thingId);
            if (Thing == null)
            {
                return "I can't find the " + thingId;
            }
            else
            {
                return Thing.FullDescription;
            }
            
            

        }



        /*execute look command
         * command will be passed in as a string array
         * command is case sensitive
         * There must be either 3 or 5 elements in the array
         * The first word must be “Look”
         * The second word must be “At”
         * the 4th word must be “In”
         * If there are 3 elements, the container is the player
         * If there are 5 elements, then the container id is the 5th word
        */
        public override string Execute(Player p, List<string> text) 
        {
            string containerId;
            IHaveInventory container;
            string itemId;
            string result = "";
            if (text.Count != 3 && text.Count !=5) 
            {
                result = "I don’t know how to look like that";
            }

            else
            {
                if (text[0] != "Look")
                {
                    result = "Error in look input";
                }

                else if (text[1] != "At")
                {
                    result = "What do you want to look at";
                }
                else
                {
                    itemId = text[2];
                    if (text.Count == 5)
                    {
                        if (text[3] != "In")
                        {
                            result = "What do you want to look in?";
                        }
                        else
                        {
                            containerId = text[4];
                            container = FetchContainer(p, containerId);
                            if (container == null)
                            {
                                result = "I can't find the " + containerId;
                            }
                            else
                            {
                                result = LookAtin(itemId, container);
                            }
                           
                        }
                    }

                    else if (text.Count == 3)
                    {
                        container = p;
                        result = LookAtin(itemId, container);

                    }
                }
            }
            return result;

        }

    }
}
