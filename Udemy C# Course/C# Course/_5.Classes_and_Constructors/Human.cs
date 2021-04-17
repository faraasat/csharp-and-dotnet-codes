using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Classes_and_Constructors
{
    class Human
    {
        // Variables
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // Constructors\
        public Human()
        {
            Console.WriteLine("Empty Constructor is called and object is created");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            if(age != 0 && lastName != null && eyeColor != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} and my eye color is {2} and age is: {3}", firstName, lastName, eyeColor, age);
            } else if (lastName != null && eyeColor != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} and my eye color is {2}", firstName, lastName, eyeColor);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
            } else
            {
                Console.WriteLine("Hi, I'm {0}");
            }
        }

    }
}
