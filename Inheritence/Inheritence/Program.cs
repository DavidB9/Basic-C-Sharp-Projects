using System;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee();
            test.FirstName = "Sample";
            test.LastName = "Student";
            test.SayName();
        }
    }
}
