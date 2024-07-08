using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public interface IBattleStates
    {
        string Name { get; set; }
        int Health { get; set; }
        int AttackPower { get; set; }
        int Defense { get; set; }

        public void CalculateDamage(int damage);
    }
}
