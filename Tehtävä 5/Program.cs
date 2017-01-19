using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekuntti, minuutti, tunti,sekuntti2;
            Console.Write("Anna aika sekuntteina");
            int.TryParse(Console.ReadLine(), out sekuntti);
            Console.Write("Aika minuutteina "+(sekuntti / 3600));
            tunti = sekuntti / 3600;//tunnit

            Console.Write("Tunteja " + tunti);
            minuutti = sekuntti / 60; //minuutit

            Console.Write("Minuutteja " + minuutti);
            sekuntti2 = sekuntti - (minuutti * 60); //sekuntit
            Console.Write("Sekuntteja " + sekuntti);

            Console.Write(tunti + minuutti + sekuntti);
           


        }
    }
}
