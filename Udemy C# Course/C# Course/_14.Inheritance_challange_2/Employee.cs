using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Inheritance_challange_2
{
    class Employee
    {

        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            Name = "Hello";
            FirstName = "Denis";
            Salary = 500000;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("I'm Working");
        }

        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }

    }
}
