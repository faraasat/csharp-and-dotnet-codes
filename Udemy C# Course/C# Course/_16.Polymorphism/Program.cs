using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "z3");  
            Car audi83 = new BMW(250, "yellow", "s3");
            bmwZ3.ShowDetails(); // Since we have use new with the mwthod therefore it will prioritize the BMW class method
            audi83.ShowDetails();
            bmwZ3.Repair();
            bmwZ3.SetCarIDInfo(1234, "Denis");
            audi83.SetCarIDInfo(2342, "Brown");
            bmwZ3.GetCarIDInfo();
            audi83.GetCarIDInfo();

            BMW b = new BMW(453, "Silver", "Hello");
            b.ShowDetails();
            b.Repair();

            Car carB = (Car)bmwZ3;
            carB.ShowDetails();

            M3 myM3 = new M3(160, "Red", "M3 Super");
            myM3.Repair();
            myM3.ShowDetails();

            Console.ReadKey();

        }
    }
}
