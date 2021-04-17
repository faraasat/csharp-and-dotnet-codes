using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteSomething();
            WriteSomethingSpecific("Hello World!");

            int result = Add(5, 3);
            Console.WriteLine(result);
            Console.WriteLine(Add(Add(2, 3), Add(3,3)));

            Console.WriteLine("Please Enter a number!");
            string input = Console.ReadLine();
            try
            {
                int strToInt = int.Parse(input);
                Console.WriteLine(strToInt);
            } 
            catch (FormatException e)
            {
                Console.WriteLine("FormatException:\n" + e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("OverflowException:\n" + e);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException:\n" + e);
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

            // Unary Operators
            int num1 = 5;
            int num3;

            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("isSunny is {0}", isSunny);

            // PreIncrement and postIncrement operators ++num, num++, 
            // relational and Type operators >, <
            // Equality operators ==, !=
            // Conditional operators &&, ||,  

            Console.Read();

        }

        // We wrote static because this method cannot be directly called in staitc method of Main
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a void method");
        }

        public static void WriteSomethingSpecific(string text)
        {
            Console.WriteLine(text);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
