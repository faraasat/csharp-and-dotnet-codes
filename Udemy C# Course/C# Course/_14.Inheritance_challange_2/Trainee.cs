using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Inheritance_challange_2
{
    class Trainee : Employee
    {

        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(int workHour, int schoolHour, string name, string firstName, int salary) : base(name,firstName,salary)
        {
            this.WorkingHours = workHour;
            this.SchoolHours = schoolHour;
        }

        public void Learn()
        {
            Console.WriteLine("I'm learning for {0} hours!", SchoolHours);
        }

        public new void Work()
        {
            Console.WriteLine("I'm working for {0} hours!", WorkingHours);
        }

    }
}
