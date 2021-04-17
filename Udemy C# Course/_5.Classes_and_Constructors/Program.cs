using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Classes_and_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Human denis = new Human("Denis", "Banis", "Blue", 30);
            denis.IntroduceMyself();
            
            Human withoutAge = new Human("Denis", "Banis", "Blue");
            withoutAge.IntroduceMyself();

            Human empty = new Human();

            Console.Read();

        }

    }
}
