using System;

namespace _1_variables_datatypes_constants
{
    class Program
    {
        // We write classes and methods in pascal case that is ClassName
        // We write arguments in camel case like firstNumber


        // Constants
        const double PI = 3.141592;
        const int weeks = 52, months = 12;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; //To change foreground color of console
            Console.BackgroundColor = ConsoleColor.Blue; //To change background color of console
            Console.Clear(); // If we do not write this the background color will only occupy text

            // These are according to coding convention
            string myStr, myBoolStr;
            int myNum;
            bool isSaved = true;
            float myFloat = 13.5F;
            double myDouble = 13.37;
            int smallNumber = 32432423;
            long bigNumber;


            myNum = (int)myDouble; // Here we are explicitly type casting double into int

            bigNumber = smallNumber;  // This is implicit typecasting
            myDouble = myFloat;

            myStr = myDouble.ToString(); // To convert any type of number into string
            myBoolStr = isSaved.ToString();

            Console.WriteLine("Int explicitly typecasted from Double: " + myNum);
            Console.WriteLine("Long implicitly typecasted from Int: " + bigNumber);
            Console.WriteLine("Double implicitly typecasted from Float: " + myDouble);
            Console.WriteLine("Double converted into string: " + myStr);
            Console.WriteLine("Boolean converted into string: " + myBoolStr);

            // These are not according to coding convention because they are classes so we avoid this
            /*String myName1;
            Int32 myNum1;
            Boolean isSaved1;*/

            string myFirstString = "15";
            string mySecondString = "15.34";
            string result = myFirstString + mySecondString;
            Console.WriteLine("Concatenation of strings: " + result);

            int myFirstInt = Int32.Parse(myFirstString);
            float mySecondFloat = float.Parse(mySecondString);
            double resultDouble = Double.Parse(result);

            Console.WriteLine("Int parsed from String: " + myFirstInt);
            Console.WriteLine("Float parsed from String: " + mySecondFloat);
            Console.WriteLine("Double parsed from String: " + resultDouble);

            Console.WriteLine("PI constant value: " + PI);
            Console.WriteLine("Weeks constant value: " + weeks);
            Console.WriteLine("Months constant value: " + months);

            Console.Read();

        }
    }
}
