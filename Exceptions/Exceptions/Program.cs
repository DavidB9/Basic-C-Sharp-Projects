using System;
using System.Collections.Generic;


namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list of integers and fill it with values
            List<int> integers = new List<int>();
            integers.Add(54);
            integers.Add(69);
            integers.Add(20);
            integers.Add(34);
            integers.Add(100);
            //Ask the user for a number to divide by
            Console.WriteLine("Please enter a number to divide the list numbers by");
            //try catch block to handle errors with input
            try
            {
                //Save the number entered by the user as a variable
                int divide = Convert.ToInt32(Console.ReadLine());

                //Create variable to hold the result of the division
                int result = 0;

                //loops through the list
                for (int i = 0; i < integers.Count; i++)
                {
                    //gets the result of the division
                    result = integers[i] / divide;
                    //displays the result to the console
                    Console.WriteLine(result);
                }
            }
            //catch for if the user entered 0
            catch (DivideByZeroException ex)
            {
                //Display the error message on the console
                Console.WriteLine(ex.Message);
            }
            //catch for format errors(strings/decimals were entered)
            catch (FormatException ex)
            {
                //Display the error message on the console
                Console.WriteLine(ex.Message);
            }
            //Message to display the try catch block is finished
            Console.WriteLine("Try/catch finished");
            Console.Read();
        }
    }
}
