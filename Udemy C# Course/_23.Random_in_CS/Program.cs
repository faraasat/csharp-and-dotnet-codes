using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Random_in_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            Random dice = new Random();
            int num;

            for (int i = 0; i < 10; i++)
            {
                num = dice.Next(1, 7);
                Console.WriteLine(num);
            }


            Random yesNoMayBe = new Random();
            int answerNum = yesNoMayBe.Next(1,4);

            if(answerNum == 1)
            {
                Console.WriteLine("Yes");
            } else if(answerNum == 2)
            {
                Console.WriteLine("May be");
            } else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();

        }
    }
}
