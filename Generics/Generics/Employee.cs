using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Employee<T> : Person, IQuittable
    {
        public int Id { get; set; }
        public List<T> things { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("Employee Quit");
        }

        public void printThings()
        {
            for(int i =0; i < things.Count; i++)
            {
                Console.WriteLine(things[i]);
            }
        }
    }
}
