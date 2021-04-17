using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Polymorphism
{
    // IS-A
    class BMW : Car
    {

        private string brand = "BMW";

        public string Model { get; set; }

        public BMW(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + " HP: " + HP + " color: " + Color);
        }

        // We can only seal override methods also we can seal class so it cannot be inherited
        public sealed override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired", Model);
        }

    }
}
