using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Reading_and_Writing_Files
{
    class Program
    {
        static void Main(string[] args)
        {

            // First Writing Method
            string[] myLines = { "First Line", "Second Line", "Third Line" };
            System.IO.File.WriteAllLines(@"../../file.txt", myLines);

            // First Reading Method
            string text = System.IO.File.ReadAllText(@"../../file.txt");
            Console.WriteLine("Text file contains following text: \n{0}", text);

            // Second Writing Method
            Console.WriteLine("Please give the File a Name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please Enter the text for File");
            string input = Console.ReadLine();
            File.WriteAllText(@"../../" + fileName + ".txt", input);

            // Second Reading Method
            string[] lines = System.IO.File.ReadAllLines(@"../../" + fileName + ".txt");
            Console.WriteLine("\nText file contains following text: \n");
            foreach (string line in lines)
            {
                Console.WriteLine("\t{0}", line);
            }

            // Third Writing Method
            using (StreamWriter file = new StreamWriter(@"../../text.txt"))
            {
                foreach (string line in myLines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            // Appending Method
            using (StreamWriter file = new StreamWriter(@"../../text.txt", true))
            {
                file.WriteLine("Additional Line.........\n");
            }

            // Third Reading Method
            using (StreamReader file = new StreamReader(@"../../text.txt"))
            {
                Console.WriteLine(file.ReadToEnd());
            }

            Console.ReadKey();

        }
    }
}
