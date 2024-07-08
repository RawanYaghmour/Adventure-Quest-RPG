using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    internal class OrdinaryMonster : monster
    {
        public OrdinaryMonster(string name, int health, int attack_power, int defense)
            : base(name, health, attack_power, defense)
        {

        }
    }
}
