using Adventure_Quest_RPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class Adventure
    {
        public monster randomMonster;
        public Item randomItem;
        public Player firstPlayer;
        public static string playerName = Console.ReadLine();
       
        public string chosenLocation = "Lobby";
        public BattleSystem battleSystem = new BattleSystem();
        public int level = 1;
        public bool isStartPlay = true;

        public Adventure()
        {
            firstPlayer = new Player(playerName, 50);
        }

        public void StartAdventure()
        {
            while (isStartPlay)
            {
                if (level > 5)
                {
                    Console.WriteLine("Congratulations! You've completed all levels!");
                    isStartPlay = false;
                    return;
                }
                if (firstPlayer.Health <= 0)
                {
                    Console.WriteLine("Game Over! Your health reached 0.");
                    isStartPlay = false;
                    return;
                }
                Console.WriteLine("Home Page");
                Console.WriteLine("Press [1] Discover a new location\n" +
                    "Press [2] Show your current location \n" +
                    "Press [3] Attack a monster\n" +
                    "Press [4] View the inventory\n" +
                    "Press [5] End the game");

                string playerChoice = Console.ReadLine();

                switch (playerChoice)
                {
                    case "1":
                        DiscoverLocation();
                        break;
                    case "2":
                        Console.WriteLine(chosenLocation);
                        break;
                    case "4":
                        // Console.WriteLine("Inventory");
                        ViewInventory();
                        break;
                    case "3":
                        bool continueAttacking = true;
                        while (isStartPlay && firstPlayer.Health > 0 && level <= 5 && continueAttacking)
                        {
                            AttackMonster();
                            if (isStartPlay && firstPlayer.Health > 0 && level <= 5)
                            {
                                Console.WriteLine($"You have reached Level {level}!");
                                Console.WriteLine($"your Health : {firstPlayer.Health} your Defense : {firstPlayer.Defense} and your Attack Power : {firstPlayer.AttackPower}");
                                ChoosePrize();
                                Console.WriteLine($"Congratulations you got {randomItem.Name} Do you want to use it ? (yes/no)");
                                string useItemChoice = Console.ReadLine().ToLower();
                                if (useItemChoice == "yes")
                                {
                                    switch (randomItem.Name)
                                    {
                                        case "potion":
                                            firstPlayer.Health += 20;
                                            Console.WriteLine(" Your Health will increase +20  ");
                                            Console.WriteLine($"your Health : {firstPlayer.Health} your Defense : {firstPlayer.Defense} and your Attack Power : {firstPlayer.AttackPower}");

                                            break;
                                        case "Armor":
                                            firstPlayer.Defense += 20;
                                            Console.WriteLine(" Your Defense will increase +20  ");
                                            Console.WriteLine($"your Health : {firstPlayer.Health} your Defense : {firstPlayer.Defense} and your Attack Power : {firstPlayer.AttackPower}");

                                            break;
                                        case "Weapon":
                                            firstPlayer.AttackPower += 20;
                                            Console.WriteLine(" Your AttackPower will increase +20  ");
                                            Console.WriteLine($"your Health : {firstPlayer.Health} your Defense : {firstPlayer.Defense} and your Attack Power : {firstPlayer.AttackPower}");
                                            break;
                                        
                                    }
                                }
                                else
                                {

                                    firstPlayer.Inventory.AddItem(randomItem);
                                    Console.WriteLine("your prize added to your inventory");
                                }
                                Console.WriteLine("Do you want to continue attacking monsters? (yes/no)");
                                string continueChoice = Console.ReadLine().ToLower();
                                if (continueChoice == "no")
                                {
                                    continueAttacking = false;
                                }
                            }
                        }
                        break;
                    case "5":
                        isStartPlay = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice, Please try again");
                        break;
                }
            }
        }

        // Choose Location
        public void DiscoverLocation()
        {
            bool display = true;
            while (display)
            {
                Console.WriteLine("Press [1] to discover Forest\nPress [2] to discover Cave\nPress [3] to discover Tower\nPress [4] Go to Home");

                string playerDiscover = Console.ReadLine();
                switch (playerDiscover)
                {
                    case "1":
                        chosenLocation = "Forest";
                        DisplayLocation();
                        display = false;
                        break;
                    case "2":
                        chosenLocation = "Cave";
                        DisplayLocation();
                        display = false;
                        break;
                    case "3":
                        chosenLocation = "Tower";
                        DisplayLocation();
                        display = false;
                        break;
                    case "4":
                        display = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice, Please try again");
                        break;
                }
            }
        }

        // Display Location
        public void DisplayLocation()
        {
            Console.WriteLine($"Your Location: {chosenLocation}");
        }


        public void ViewInventory()
        {

            string isEmpty = firstPlayer.Inventory.DisplayTheInventory();
            if (isEmpty != "")
            {
                Console.WriteLine(isEmpty);
            }


        }
        // Choose Monster
        public void ChooseMonster()
        {
            OrdinaryMonster green = new OrdinaryMonster("green", 100, 50, 30);
            OrdinaryMonster blue = new OrdinaryMonster("blue", 100, 50, 30);
            OrdinaryMonster monster = new OrdinaryMonster("monster", 100, 50, 30);
            BossMonster boss = new BossMonster();

            monster[] monsters = { green, blue, monster, boss };

            Random random = new Random();
            int randomIndex = random.Next(monsters.Length);
            randomMonster = monsters[randomIndex];
        }


        public void ChoosePrize()
        {
            
            Armor armor = new Armor();
            Weapon weapon = new Weapon();
            potion potion = new potion();


            Item[] items = { weapon, potion, armor };

            Random random = new Random();
            int randomIndex = random.Next(items.Length);
            randomItem = items[randomIndex];
        }
        public void AttackMonster()
        {
            ChooseMonster();

            if (randomMonster == null)
            {
                Console.WriteLine("No monsters available to attack.");
                return;
            }

            Console.WriteLine($"A {randomMonster.Name} monster appears!");

            bool isPlayerWin = BattleSystem.StartBattle(firstPlayer, randomMonster);

            if (isPlayerWin)
            {
                Console.WriteLine($"You defeated the {randomMonster.Name} monster!\n");
                //level++;
            }
            else
            {
                Console.WriteLine("You have been defeated...");
                isStartPlay = false;
            }

            if (firstPlayer.Health <= 0)
            {
                Console.WriteLine("Game Over! Your health reached 0.");
                isStartPlay = false;
            }
        }
    }
}


