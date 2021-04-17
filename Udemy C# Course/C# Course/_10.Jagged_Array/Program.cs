using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jagged Array is an array in an array
            //                                          0                       1                   2
            // Jagged Array of type int is as : [array1([15],[13],[5])],[array2([7],[8],[2])],[array3([2],[4],[1])]

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 4, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 1, 2 };
            Console.WriteLine("The value in the middle of first entry is: {0}", jaggedArray[0][3]);

            int[] myNum = new int[] { 5, 4, 7, 3, 2, 4, 6 };
            // Alternative way
            int[][] jaggedArray1 = new int[][]
            {
                new int[] { 2, 3, 4, 7, 11 },
                new int[] { 1, 2, 3 },
                myNum,
            };

            for(int i = 0; i < jaggedArray1.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray1[i].Length; j++)
                {
                    Console.WriteLine("{0}", jaggedArray1[i][j]);
                }
            }
            Console.Read();
        }
    }
}
