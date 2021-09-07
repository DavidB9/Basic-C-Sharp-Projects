using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp1 = new Employee<string>();
            emp1.things = new List<string>();
            emp1.things.Add("Things");
            emp1.things.Add("Stare");
            emp1.things.Add("Lot");
            emp1.things.Add("Sting");
            emp1.things.Add("Orange");

            Employee<int> emp2 = new Employee<int>();
            emp2.things = new List<int>();
            emp2.things.Add(5);
            emp2.things.Add(9);
            emp2.things.Add(7);
            emp2.things.Add(6);
            emp2.things.Add(10);

            emp1.printThings();
            emp2.printThings();

            Console.Read();
        }
    }
}
