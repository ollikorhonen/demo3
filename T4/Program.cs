using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            vehicle vehicle = new vehicle();

            vehicle.PrintData();

            vehicle.Name = "Audi";
            vehicle.Speed = 200;
            vehicle.Tyres = 10;
            vehicle.PrintData();

            Console.WriteLine(vehicle.ToString());

            vehicle vehicle2 = new vehicle();

            vehicle.Name = "Lada";
            vehicle.Speed = 350;
            vehicle.Tyres = 4;
            vehicle.PrintData();

            Console.WriteLine(vehicle.ToString());

            Console.ReadLine();
        }
    }
}
