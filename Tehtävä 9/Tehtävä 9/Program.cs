using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int /*summa*/  luku; //alku;
                                //alku = 0 + summa;
                                
            Console.Write("Anna luku ");
            do {
                luku = int.Parse(Console.ReadLine());
                

                Console.Write("Anna luku ",+luku);
            } while (luku != 0);
            
            Console.Write("xaxaxa"/*+summa*/);
        }
    }
}
