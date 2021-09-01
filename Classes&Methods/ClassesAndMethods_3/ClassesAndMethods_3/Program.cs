using System;

namespace ClassesAndMethods_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MoreMathOps testOps = new MoreMathOps();
            testOps.test(5,5);
            testOps.test(x: 6, y: 10);
            Console.Read();
        }
    }
}
