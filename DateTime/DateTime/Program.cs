using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine("Please enter the number of hours");
            int num = Convert.ToInt32(Console.ReadLine());
            date = date.AddHours(num);
            Console.WriteLine(date);
            Console.Read();
        }
    }
}
