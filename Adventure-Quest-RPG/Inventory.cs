using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class Inventory
    {
        List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {

            items.Add(item);
        }

        public string DisplayTheInventory()
        {

            if (items.Count == 0)
            {
                return "Empty Inventory! \n";


            }

            Console.WriteLine("you have this items in your inventory");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].Name} - {items[i].Description}");

            }
            return "";

        }
        public Item GetItemByIndex(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }
            return null;
        }
        public void Remove(Item item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine($"{item} removed from inventory.");
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
            }
        }
    }
}