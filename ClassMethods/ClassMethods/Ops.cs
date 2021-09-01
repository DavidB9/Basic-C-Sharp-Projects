using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethods
{
    class Ops
    {
        public void div(int x)
        {
            x = x / 2;
            Console.WriteLine("Result is: " + x);
        }

        public void outParameters(out int x)
        {
            int temp = 5;
            x = temp;
        }
        public decimal div(decimal x)
        {
            x = x / 2;
            return x;
        }
    }
}
