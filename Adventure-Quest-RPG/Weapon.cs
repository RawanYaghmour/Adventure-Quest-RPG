using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adventure_Quest_RPG
{
    internal class Weapon : Item
    {
        
        public Weapon() : base("Weapon", "using a Weapon will increase your attack power by +20", 20)
        {
        }
    }
}
