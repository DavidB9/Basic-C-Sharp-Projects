using System;

namespace MoreExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            bool valid = false;
            DateTime date = DateTime.Now;
            int year = date.Year;
            int age = 0;

            try
            {
                while (!valid)
                {
                    valid = int.TryParse(Console.ReadLine(), out age);
                    if (!valid) Console.WriteLine("Please enter digits only, no decimals");
                }
                if (age <= 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    year -= age;
                    Console.WriteLine("You were born in {0}", year);
                }
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Please enter valid input");
                Console.ReadLine();
                return;
            }

            catch (Exception)
            {
                Console.WriteLine("An error occured");
                Console.ReadLine();
                return;
            }

            Console.Read();
        }

    }
}
