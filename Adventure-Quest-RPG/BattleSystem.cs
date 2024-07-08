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
        List<Items> dropedItems;
        private Random random;
        private int Round;

        public BattleSystem()
        {

            chosenDropedItems();
            random = new Random();

        }






        public  void Attack(IBattleStates attacker, IBattleStates target)
        {

            //Console.WriteLine($"Round :{round}\n");

            int damage = Math.Max(attacker.AttackPower - target.Defense, 0);
            target.CalculateDamage(damage);

            Thread.Sleep(1000);
      
            Console.Beep();
            Console.WriteLine($"\n{attacker.Name} attacks {target.Name} for {damage} damage.");
            Console.WriteLine($"{target.Name}'s health is now {target.Health}%.");

        }

        public  bool StartBattle(Player player, monster enemy)
        {
            player.Name = "Rawan";
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


        public void chosenDropedItems()
        {
            dropedItems = new List<Items>
            {
                new Potion("Healing Potion", 50),
                new DefensiveStructures(" Safe Zone ", 50),
                new ThunderSpears("Thunder Spears", 30),
                new PersonalArmor(" Steel Armor ", 30),
                new UltrahardSteelBlades(" Steel Blades ", 50),
                new ODM_Gear(" Scout Regiment Gear ", 25)

            };
        }


        public void chanceItems(Player player)
        {
            int randomnumber = random.Next(1, 24);
            if (randomnumber <= 25)
            {
                int indexDropItem = random.Next(dropedItems.Count);
                player.Inventory.AddItem(dropedItems[indexDropItem]);
                Console.WriteLine($"You found a {dropedItems[indexDropItem].Name}!");
            }
            else
            {
                Console.WriteLine("You Did not get any item ");
            }
        }





    }
}
