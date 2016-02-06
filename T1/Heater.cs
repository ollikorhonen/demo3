using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Heater
    {
        // properties
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public bool IsOn { get; set; }

        // method prints object data to screen
        public void PrintData()
        {
            Console.WriteLine("Heater data");
            Console.WriteLine("Temp {0}", Temperature);
            Console.WriteLine("Humi {0}", Humidity);
            Console.WriteLine("IsOn {0}", IsOn);
        }
        // methid returns object properties in a ine string
        public override string ToString()
        {
            return "Temp = " + Temperature + " Humi = " + Humidity + " IsOn = " + IsOn;
        }

    }
}
