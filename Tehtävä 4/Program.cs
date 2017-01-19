using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä 4
{
    class Program
    {


        static void Main(string[] args)
        {
            int ika; //määritellään muuttujat

            Console.WriteLine("Kerro ikäsi"); //Vastaa cout komentoa
            //Kysytään käyttäjältä luvut
            int.TryParse(Console.ReadLine(), out ika);

            if (ika < 18) { Console.WriteLine("ALAIKAINEN!"); }
            if (ika >= 18 && ika <= 65) { Console.WriteLine("Aikuinen!"); }
            if (ika > 65) { Console.WriteLine("Seniori!"); }

            Console.ReadLine();


        }
    }

}