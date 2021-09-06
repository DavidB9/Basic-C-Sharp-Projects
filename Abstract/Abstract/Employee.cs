using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Employee : Person , IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("Employee Quit");
        }

        public static bool operator==(Employee em, Employee em2)
        {
            return em.Id == em2.Id;
        }

        public static bool operator !=(Employee em, Employee em2)
        {
            return em.Id == em2.Id;
        }
    }
}
