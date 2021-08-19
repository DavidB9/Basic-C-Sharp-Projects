using System;

namespace Math_Operation_Assignment
{
    class Program
    {
        static void Main()
        {
            //1.Takes an input from the user, multiplies it by 50, and prints the result to the console.
            Console.WriteLine("Please enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your output is: " + (num1 * 50));

            //2. Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Please enter a number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your output is: " + (num2 + 25));

            //3. Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Please enter a number:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your output is: " + (num3 / 12.5));

            //4. Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
            Console.WriteLine("Please enter a number:");
            double num4 = Convert.ToDouble(Console.ReadLine());
            bool isGreater = num4 > 50;
            Console.WriteLine("Your output is: " + isGreater);

            //5. Takes an input from the user, divides it by 7, and prints the remainder to the console.
            Console.WriteLine("Please enter a number:");
            double num5 = Convert.ToDouble(Console.ReadLine());
            double remainder = num5 % 7;
            Console.WriteLine("Your output is: " + remainder);
            Console.Read();
        }
    }
}
