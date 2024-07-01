namespace Adventure_Quest_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Player firstPLayer = new Player("Hubot ", 50);
                GreenMonster green = new GreenMonster();
                BattleSystem.StartStartBattle(firstPLayer, green);


            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error occurred:", ex.Message);
            }




            Console.WriteLine("\nAdventure complete!");
        }
    }
}
