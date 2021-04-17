using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Members_and_finalizers_destructor
{
    class Members
    {

        // Member - private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        // Member - public field
        public int age;

        // Member Constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            jobTitle = "Developer";
            Console.WriteLine("Object Created");
        }

        // Menber - Finalizer or Destructure also we should not create empty finalizer because it reduces performance
        ~Members()  // A class can have one finalizer or destructure and cannot be inherited, overloaded or called
        {
            //cleanup statements
            Console.WriteLine("");
            Debug.WriteLine("Deconstruction of Member Object");
        }


        // Member Property
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            } else
            {
                Console.WriteLine("Hi, my name is {0} and my job title is {1} and I'm {2} years old", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My Salary is: {0}", salary);
        }

    }
}
