using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new car object
            car car = new car();
            car.PrintData();
            car.Model = "Datsun 100A";
            car.Color = "Yellow";
            car.Engine = 0.4;
            car.Accelerate();
            car.PrintData();

            // create another car object
            string model = "jeep"; 
            car car2 = new car(model);
            car2.PrintData();
            car2.Color = "Black";
            car2.Engine = 5.0;
            car2.DoorCount = 4;
            car2.FuzzyDices = false;
            car2.Brake();
            car2.PrintData();





            Console.ReadLine();

        }
    }
}
