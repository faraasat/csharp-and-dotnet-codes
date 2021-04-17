using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arrays
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;
            Console.WriteLine("Grade at index 0 is {0}", grades[0]);

            int[] gradeOfMathsA = { 2, 5, 7, 3, 2 };

            // For Each
            string[] myFirends = new string[] { "Ali", "Mubashir", "Bilal", "Fawad", "Aijaz", "Abbas" };
            int counter = 0;
            foreach (string k in myFirends)
            {
                Console.WriteLine("Element{0} is: {1}", counter, k);
                counter++;
            }

            // 2-D Array
            int[,] array2D = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // 3-D Array
            string[,,] array3D = new string[,,]
            {
                {
                    { "000", "001" },
                    { "010", "011" },
                    { "Hi there!", "What's up?" },
                },
                {
                    { "'100", "101" },
                    { "110", "111" },
                    { "Another one", "last entry" },
                }
            };

            string[,] array2DString = new string[3, 2]
            {
                { "one", "two" },
                { "three", "four" },
                { "five", "six" }
            };

            int dimensions = array2DString.Rank; // For dimensions
            Console.WriteLine(dimensions);

            Console.Read();

        }
    }
}
