using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.DateTime_in_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dateTime = new DateTime(1988, 5, 31);
            Console.WriteLine("His Birthday is: {0}", dateTime);

            dateTime = new DateTime();
            Console.WriteLine(dateTime);

            // To write current date
            Console.WriteLine(DateTime.Today);
            // To write current time
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Today is: ", DateTime.Today.DayOfWeek);

            DateTime tommorrow = GetTommorrow();
            Console.WriteLine("Tommorrow will be: {0}", tommorrow);

            Console.WriteLine(GetFirstDayOfYear(2020));

            int days = DateTime.DaysInMonth(2020, 2);
            Console.WriteLine("Days in Feb 2020 are: " + days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}", now.Minute);

            Console.WriteLine("Write the date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since {0}", daysPassed.Days);
            } else
            {
                Console.WriteLine("Wrong Input");
            }
            
            Console.ReadKey();

        }

        static DateTime GetTommorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }

    }
}
