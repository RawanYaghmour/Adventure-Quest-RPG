using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adventure_Quest_RPG
{
    public abstract class monster : Character
    {
        public monster(string name, int health, int attack_power, int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attack_power;
            Defense = defense;
        }
    }
}
