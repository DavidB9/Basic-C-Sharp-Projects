using System;
using System.IO;

namespace FIle_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string number = Console.ReadLine();
            Console.WriteLine(number);

            using(StreamWriter file = new StreamWriter("file.txt",true))
            {
                file.WriteLine(number + " ");
            }
            using(StreamReader file = new StreamReader("file.txt", true))
            {
                Console.WriteLine(file.ReadToEnd());
            }
            Console.Read();
        }
    }
}
