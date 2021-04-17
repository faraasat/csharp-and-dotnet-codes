using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Structs_in_CS
{
    class Program
    {

        // We cannot create default constructors and donot support inheritance but they can be implemented by interface
        public struct Game
        {
            public string name;
            public string developer;
            public double rating;
            public string releaseDate;

            // But we cannot call methods before assignment of all variable
            public Game(string name, string developer, double rating, string releaseDate)
            {
                this.name = name;
                this.developer = developer;
                this.rating = rating;
                this.releaseDate = releaseDate;
            }

            public void Display()
            {
                Console.WriteLine("Game1's name is {0}, develpoed by {1}, rating is {2} and release date is {3}", name, developer,
                rating, releaseDate);
            }
        }

        static void Main(string[] args)
        {

            Game game1;

            game1.name = "Pokemon Go";
            game1.developer = "Nniantic";
            game1.rating = 3.5D;
            game1.releaseDate = "01.07.2016";
            game1.Display();

        }
    }
}
