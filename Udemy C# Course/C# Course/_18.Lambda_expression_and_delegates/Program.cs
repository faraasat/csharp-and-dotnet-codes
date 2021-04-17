using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Lambda_expression_and_delegates
{
    class Program
    {

        // Delegates can take function as parameter
        public delegate int SomeMath(int i);
        public delegate bool Compare(int i, Number n);

        static void Main(string[] args)
        {

            DoSomething();

            Console.ReadKey();

        }

        public static void DoSomething()
        {
            // Delegate calling a method but we cannot give two parameters to delegate
            SomeMath maths = new SomeMath(Square);
            Console.WriteLine(maths(8));

            SomeMath math2 = new SomeMath(TimesTen);
            Console.WriteLine(math2(8));

            // Delegate on fly
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = list.FindAll(delegate (int i)
            {
                return (i % 2 == 0);
            });
            foreach (int even in evenNumbers)
            {
                Console.WriteLine(even);
            }

            // Same as above but in less lines using lambda expression
            List<int> oddNumbers = list.FindAll(i => i % 2 != 0);
            oddNumbers.ForEach(i =>
            {
                Console.WriteLine("Odd Number:");
                Console.WriteLine(i);
            });


            maths = new SomeMath(x => x * x * x);
            Console.WriteLine(maths(8));

            Compare comp = (a, number) => a == number.n;
            Console.WriteLine(comp(5, new Number { n = 5 }));

        }

        public static int Square(int i)
        {
            return i * i;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int TimesTen(int i)
        {
            return i * 10;
        }

    }

    public class Number
    {
        public int n { get; set; }
    }

}
