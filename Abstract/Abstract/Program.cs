using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            bool equal = false;
            Employee emp = new Employee();
            emp.FirstName = "Sample";
            emp.LastName = "Student";
            emp.Id = 5;
            emp.SayName();
            IQuittable test = new Employee();

            test.Quit();
            Employee emp2 = new Employee();
            emp2.Id = 6;
            equal = emp == emp2;
            Console.WriteLine(equal);
            Console.Read();
        }


    }
}
