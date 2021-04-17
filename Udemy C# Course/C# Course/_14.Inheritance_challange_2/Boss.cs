using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Inheritance_challange_2
{
    class Boss : Employee
    {

        public string CompanyCar { get; set; }

        public Boss(string companyCar, string name, string firstName, int salary) : base(name, firstName, salary)// base is for base constructor
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I'm Boss");
        }

    }
}
