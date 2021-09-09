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
            File.WriteAllText("file.text", number);
            Console.WriteLine(File.ReadAllText("file.text"));
            Console.Read();
        }
    }
}
