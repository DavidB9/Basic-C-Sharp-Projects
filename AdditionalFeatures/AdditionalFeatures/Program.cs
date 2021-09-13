using System;

namespace AdditionalFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            const string message = "Welcome";
            Console.WriteLine(message);
            var player = new Player("David", 75);
            var player2 = new Player("Cian");

            Console.WriteLine(player.playerHealth);
            Console.WriteLine(player2.playerHealth);
            Console.Read();
        }
    }
}
