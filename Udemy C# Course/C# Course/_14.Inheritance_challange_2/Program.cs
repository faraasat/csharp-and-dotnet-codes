using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Inheritance_challange_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee michael = new Employee("Michael", "Miller", 40000);
            michael.Work();
            michael.Pause();

            Boss chuck = new Boss("Ferrari", "Norris", "Chuck", 90000);
            chuck.Lead();

            Trainee michelle = new Trainee(32, 8, "Gartner", "Michelle", 1000);
            michelle.Learn();
            michelle.Work();    

            Console.ReadKey();

        }
    }
}
