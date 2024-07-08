using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public abstract class Item
    {
        public string Name{ get; set;}
        public string Description { get; set; }
        public int Value { get; set; }

        protected Item(string name, string description, int value)
        {
            Name = name;
            Description = description;
            Value = value;
        }
    }
}
