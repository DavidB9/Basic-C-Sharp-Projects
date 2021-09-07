using System;
using System.Collections.Generic;
using System.Linq;

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

            //create a list of employees
            List<Employee> employees = new List<Employee>();
            //create 10 employee objects
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();
            Employee employee6 = new Employee();
            Employee employee7 = new Employee();
            Employee employee8 = new Employee();
            Employee employee9 = new Employee();
            Employee employee10 = new Employee();

            //assign them values
            employee1.FirstName = "Joe";
            employee1.LastName = "Smith";
            employee1.Id = 3;

            employee2.FirstName = "Cian";
            employee2.LastName = "Murphy";
            employee2.Id = 75;

            employee3.FirstName = "Joe";
            employee3.LastName = "Daniels";
            employee3.Id = 2;

            employee4.FirstName = "David";
            employee4.LastName = "Buckingham";
            employee4.Id = 5;

            employee5.FirstName = "Eileen";
            employee5.LastName = "Murphy";
            employee5.Id = 7;

            employee6.FirstName = "Sean";
            employee6.LastName = "Weiss";
            employee6.Id = 12;

            employee7.FirstName = "Jordan";
            employee7.LastName = "Summers";
            employee7.Id = 11;

            employee8.FirstName = "Alan";
            employee8.LastName = "Denvers";
            employee8.Id = 15;

            employee9.FirstName = "Conner";
            employee9.LastName = "Smith";
            employee9.Id = 91;

            employee10.FirstName = "Niall";
            employee10.LastName = "Dunne";
            employee10.Id = 17;

            //add them to the list
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);

            List<Employee> joes = new List<Employee>();

            //loop for finding employees with the first name joe
            foreach(Employee employee in employees)
            {
               if(employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            //Lambda  expression for creating new list with the first Name Joe
            List<Employee> lambdaJoes = employees.Where(emp => emp.FirstName == "Joe").ToList();

            //Lambda  expression for creating a list with the id greater than 5
            List<Employee> greaterID = employees.Where(x => x.Id > 5).ToList();

            Console.Read();
        }


    }
}
