using System;

namespace ClassesAndMethods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            test testOp = new test();
            int result;
            Console.WriteLine("Please enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number(optional)");
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                result = testOp.outPara(num1, num2);
                Console.WriteLine("Result: " + result);
            }
            catch(Exception ex)
            {
                result = testOp.outPara(num1);
                Console.WriteLine("Result: " + result);
            }
            Console.Read();
        }
    }
}
