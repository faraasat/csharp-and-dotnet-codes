using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Nullables_in_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            // To write Nullables int we cannot assign null to normal variable and also nullables can be empty
            int? num1 = null;
            int? num2 = 2412;
            Console.WriteLine(num1 + ", " + num2);

            double? num3 = null;
            double? num4 = 2432.234;
            Console.WriteLine(num3 + ", " + num4);

            bool? boolVal = null;
            Console.WriteLine(boolVal + ", ");

            bool? isMale = null;
            if(isMale == true)
            {
                Console.WriteLine("User is male");
            } else if (isMale == false)
            {
                Console.WriteLine("User is female");
            } else
            {
                Console.WriteLine("Not Specified");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double? num8;

            // ?? It check if num5 has a value and assign it else assign another value and it is call NULL COALESCING OPERATOR
            num8 = num6 ?? 8.53;
            Console.WriteLine("Value of num8 is: {0}", num8);
            num8 = num7 ?? 8.53;
            Console.WriteLine("Value of num8 is: {0}", num8);


            Console.ReadLine();

        }
    }
}
