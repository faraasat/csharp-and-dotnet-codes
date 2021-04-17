using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Math_Obj_in_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ceiling: " + Math.Ceiling(11.5));
            Console.WriteLine("Ceiling: " + Math.Floor(11.5));

            int num1 = 13, num2 = 9;
            Console.WriteLine("Lower among num1 {0} and num2 {1} is: {2}", num1, num2, Math.Min(num1, num2));
            Console.WriteLine("Higher among num1 {0} and num2 {1} is: {2}", num1, num2, Math.Max(num1, num2));

            Console.WriteLine("3 to the power 5 is {0}", Math.Pow(3,5));
            Console.WriteLine("value of PI is {0}", Math.PI);

            Console.WriteLine("square root of 25 is {0}", Math.Sqrt(25));
            Console.WriteLine("Absolute root of -25 is {0}", Math.Abs(-25));
            Console.WriteLine("Cos of 1 is {0}", Math.Cos(1));
            


            Console.ReadKey();

        }
    }
}
