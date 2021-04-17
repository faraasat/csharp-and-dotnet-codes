using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // For Loop
            for (int counter = 0; counter < 50; counter+=5)
            {
                Console.WriteLine(counter + " is lower than 50");
            }

            // Do - While Loop
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfFriend = Console.ReadLine();
                int currentLength = nameOfFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfFriend + ", ";
            } while (lengthOfText < 20);
            Console.WriteLine("Thank you that was enough: " + wholeText);

            // While Loop
            int count = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else " +
                    " + enter if you want to finish counting");
                enteredText = Console.ReadLine();
                count++;
                Console.WriteLine("Current People Count is {0} ", count);
            }
            Console.WriteLine("{0} people are inside the bus. Press enter to close the program", count);

            // Break and Continue
            for (int counter = 0; counter < 50; counter += 5)
            {
                if(counter %2 == 0)
                {
                    Console.WriteLine("Now Comes an odd Number:");
                    continue;
                }
                Console.WriteLine(counter);
            }

            Console.Read();

        }

    }
}
