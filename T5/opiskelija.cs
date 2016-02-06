using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class opiskelija
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Puhnum { get; set; }
        public int Ika { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Profiili\n");
            Console.WriteLine("Etunimi :  {0}", Etunimi);
            Console.WriteLine("Sukunimi : {0}", Sukunimi);
            Console.WriteLine("Puhnum :   {0}", Puhnum);
            Console.WriteLine("Ika :      {0}", Ika);

        }

    }
}
