using System;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Ops testOp = new Ops();

            Console.WriteLine("Please enter a number to be divided by 2:");
            int num = Convert.ToInt32(Console.ReadLine());
            testOp.div(num);

            int a = 100;
            testOp.outParameters(out a);
            Console.WriteLine("a was 100 and is now: " + a);

            //overloaded method
            decimal result = testOp.div(50.2m);
            Console.WriteLine("Overloaded method returns: " + result);

            Console.Read();
        }
    }
}
