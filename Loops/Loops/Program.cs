using System;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            bool isGuessed = false;
            int number;
            bool guess = false;
            Random rnd = new Random();
            int randomNum = rnd.Next(1, 100);
            

            while (isGuessed == false)
            {
                Console.WriteLine("Pick a number between 1 and 100:");
                number = Convert.ToInt32(Console.ReadLine());

                if (number == 57)
                {
                    Console.WriteLine("You guessed correctly the number was 57");
                    isGuessed = true;
                }
                else
                {
                    Console.WriteLine("you guessed wrong try again");
                }
            }

            do
            {
                Console.WriteLine("Pick a number between 1 and 100:");
                number = Convert.ToInt32(Console.ReadLine());

                if (number == randomNum)
                {
                    Console.WriteLine("You guessed correctly the number was " + randomNum);
                    guess = true;
                }
                else
                {
                    Console.WriteLine("you guessed wrong try again");
                }
            }

            while (!guess && isGuessed);

        }
    }
}
