namespace Adventure_Quest_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the RPG game!");
            Console.WriteLine("\nEnter your name \n");
            try
            {
                Adventure adventure = new Adventure();
                adventure.StartAdventure();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            Console.WriteLine("\nFinsh Game!");
        }
    }
}