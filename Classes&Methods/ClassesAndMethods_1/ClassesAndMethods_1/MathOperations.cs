using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndMethods_1
{
    class MathOperations
    {
        public int Add(int x)
        {
            x = x + 5;
            return x;
        }
        public decimal Add(decimal x)
        {
            x = x + 5.5m;
            return x;
        }
        public int Add(string x)
        {
            int  y = Convert.ToInt32(x);
            y += 10;
            return y;
        }
    }
}
