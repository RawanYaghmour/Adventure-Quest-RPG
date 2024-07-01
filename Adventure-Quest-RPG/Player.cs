using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adventure_Quest_RPG
{
    public class Player : Character
    {
        public Player(string name, int attackPower = 60)
        {

            Name = name;
            Health = 100;
            AttackPower = attackPower;
            Defense = 20;
        }
    }
}
