using System;

namespace ClassesAndMethods_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();
            int result = mathOps.Add(3);
            decimal result2 = mathOps.Add(5.6m);
            int result3 = mathOps.Add("6");

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.Read();
        }
    }
}
