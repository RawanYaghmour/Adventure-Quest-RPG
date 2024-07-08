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

        public Inventory Inventory { get; set; }
        public Player(string name, int attackPower )
        {

            Name = name;
            Health = 200;
            AttackPower = attackPower;
            Defense = 50;
            Inventory = new Inventory();
        }
    }
}
