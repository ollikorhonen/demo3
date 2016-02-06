using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Profiili = new int [3];
            for (int i = 0; i < Profiili.Length; i++) ;
           
            opiskelija opiskelija = new opiskelija();

            Console.WriteLine("Etunimi: ");
            Console.ReadLine();
            Console.WriteLine("Sukunimi: ");
            Console.WriteLine("Puhnum: ");
            Console.WriteLine("Ika: ");

            opiskelija.PrintData();
            Console.ReadLine();

        }
    }
}
