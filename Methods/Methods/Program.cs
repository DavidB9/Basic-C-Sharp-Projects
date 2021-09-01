using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of the MathOps class
            MathOps testMath = new MathOps();

            //ask the user for a number
            Console.WriteLine("Please enter a number to do the math operations on:");

            //save the number as a variable
            int num = Convert.ToInt32(Console.ReadLine());

            //save the three results of the class methods to variables
            int result1 = testMath.add(num);
            int result2 = testMath.sub(num);
            int result3 = testMath.multiply(num);

            //Display the results on the console
            Console.WriteLine("Add 10 " + result1);
            Console.WriteLine("Subtract by 1 " + result2);
            Console.WriteLine("Multiply by 5 " + result3);

        }
    }
}
