using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public abstract class Character : IBattleStates
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }

        public void CalculateDamage(int damage)
        {
            if (Defense >= damage)
            {
                Defense -= damage;
            }
            else
            {
                int remainingDamage = damage - Defense;
                Defense = 0;
                Health -= remainingDamage;

                if (Health < 0)
                {
                    Health = 0;
                }
            }
        }
    }
}