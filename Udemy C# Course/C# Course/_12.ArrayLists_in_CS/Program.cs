using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ArrayLists_in_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare ArrayList with undefined amount of object
            ArrayList myArrayList = new ArrayList();

            //Declare ArrayList with defined amount of object
            ArrayList myArrayList1 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(true);
            myArrayList.Add(13);
            myArrayList.Add(false);

            // Delete first element with specific value
            myArrayList.Remove(13);

            // Delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;
            foreach (object obj in myArrayList)  // here obj is type of object so we have to typecast it
            {
                if(obj is int || obj is double)
                {
                    sum += Convert.ToDouble(obj);
                } else if(obj is string || obj is bool)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);

            Console.ReadKey();

        }
    }
}
