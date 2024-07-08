using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class potion:Item
    {
        public potion() : base("potion", "using a potion will increase your health by +20", 20)
        {
        }
    }
}
