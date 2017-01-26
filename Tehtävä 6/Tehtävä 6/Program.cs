using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double bensa = 7.02;
            double hinta = 1.595;
            double kulutus;
            double kustannus;
            int matka;

            Console.Write("Anna matka ");


            int.TryParse(Console.ReadLine(), out matka);
            kustannus = matka / 100 * hinta;
            kulutus = matka / 100 * bensa;




            Console.Write("Bensaa kuluu " + kulutus);
            Console.Write("\nKustannus" + kustannus, "euroa\n");


        }
    }
}
