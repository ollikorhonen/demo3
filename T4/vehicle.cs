using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class vehicle
    {
        //ominaisuudet

        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        //toiminta tulostaa ominaisuudet näytölle
        public void PrintData()
        {
            Console.WriteLine("\nVehicle data: ");
            Console.WriteLine("Name :  {0}", Name);
            Console.WriteLine("Speed : {0}", Speed);
            Console.WriteLine("Tyres : {0}\n", Tyres);
        }

        public override string ToString()
        {
            return "Name = " + Name + " Speed = " + Speed + " Tyres = " + Tyres;
        }

    }
}
