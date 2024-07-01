using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class BattleSystem
    {
        public static void Attack(Character attacker, Character target)
        {

            //Console.WriteLine($"Round :{round}\n");

            int damage = Math.Max(attacker.AttackPower - target.Defense, 0);
            target.CalculateDamage(damage);

            Thread.Sleep(1000);
      
            Console.Beep();
            Console.WriteLine($"\n{attacker.Name} attacks {target.Name} for {damage} damage.");
            Console.WriteLine($"{target.Name}'s health is now {target.Health}%.");

        }

        public static bool StartStartBattle(Player player, monster enemy)
        {
            int Round = 0;
            bool isPlayerWin = false;
            while (player.Health > 0 && enemy.Health > 0)
            {
                Round++;
                Console.WriteLine("Player's turn.");
                Attack(player, enemy);
                Thread.Sleep(2500);
                // Console.Clear();
                if (enemy.Health <= 0)
                {
                    Console.Beep();
                    Console.WriteLine("\nVictory! You have defeated the monster!");
                    Thread.Sleep(2500);
                    isPlayerWin = true;
                    break;

                }
                if (player.Health > 0)
                {
                    Console.WriteLine($"\nRound {Round} - Enemy's turn.");
                    Attack(enemy, player);
                    Thread.Sleep(2500);
                }
                if (player.Health <= 0)
                {
                    Console.Beep();
                    Console.WriteLine($"\nDefeat! You have been slain by the monster in round {Round}.");
                    Thread.Sleep(2500);
                    isPlayerWin = false;
                    break;

                }
            }
            return isPlayerWin;

        }
    }
}
