using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3.Decision_Making_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            // If Else Statement
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            // int number; we can also write like this
            if (int.TryParse(temperature, out int number)) // If the tryPars succeed then out will put the number in that variable
            {
                numTemp = number;
            } else
            {
                numTemp = 0;
                Console.WriteLine("Value Entered is not number, temperature set as 0");
            } 
            
            if (numTemp < 20)
            {
                Console.WriteLine("Take a Coat.");
            } else if (numTemp == 20)
            {
                Console.WriteLine("Pants and Pull over should be fine.");
            } else if (numTemp > 30)
            {
                Console.WriteLine("Its Super Hot!");
            } else
            {
                Console.WriteLine("Shorts are Enough Today.");
            }

            // Nested if
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please Enter a name: ");
            userName = Console.ReadLine();
            if(isRegistered)
            {
                Console.WriteLine("Hi there, registered user");
                if(userName != "")
                {
                    Console.WriteLine("Hi there, " + userName);
                    if(userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
            }

            // Switch statement
            int age = 25;
            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to Vote");
                    break;
                case 25:
                    Console.WriteLine("You can Vote");
                    break;
                default:
                    Console.WriteLine("We don't know");
                    break;
            }

            // Ternary Operator
            // The conditional operator is right - associative
            // The expression a ? b : c ? d : e is evaluated as a ? b : (c ? d : e) not as (a ? b : c) ? d : e
            // The conditional operator cannot be overloaded
            int temp = -5;
            string stateOfMatter = temp > 100 ? "gas" : temp < 0 ? "solid" : "liquid";
            Console.WriteLine("State of Matter is: " + stateOfMatter);


            Console.Read();
                
        }

    }
}
