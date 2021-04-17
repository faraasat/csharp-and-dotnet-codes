using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ArrayList_vs_List
{
    class Program
    {
        static void Main(string[] args)
        {

            // immutable - limited to one type
            int[] scores = new int[] { 99, 96, 87, 76 };

            // In list we can search and sort and they can contain one datatype
            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0);
            list.Add(56);
            list.Add(4);
            list.Sort();
            list.RemoveRange(2, 2);
            list.ForEach(i => Console.WriteLine(i));
            Console.WriteLine(list.Contains(4));
            Console.WriteLine(list.FindIndex(x => x == 4));

            // It can containe more than one datatype
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("World");
            arrayList.Add(4);
            arrayList.Add("Hello");
            arrayList.Add(56);
            arrayList.Add("Hello");
            arrayList.Add(234.34);
            arrayList.Add(true);
            arrayList.Add(false);
            arrayList.Add(new Number { n = 4 });
            foreach(Object o in arrayList)
            {
                Console.WriteLine(o);
            }

            Console.ReadKey();

        }
    }

    class Number
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }

    }

}
