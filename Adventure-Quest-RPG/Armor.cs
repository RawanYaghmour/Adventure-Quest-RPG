using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adventure_Quest_RPG
{
    internal class Armor:Item
    {
       
        public Armor() : base("Armor", "using a Armor will increase your defense by +20", 20)
        {
        }
    }
}
