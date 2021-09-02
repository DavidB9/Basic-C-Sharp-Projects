using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.FirstName = "Sample";
            emp.LastName = "Student";
            emp.SayName();
            Console.Read();
        }
    }
}
