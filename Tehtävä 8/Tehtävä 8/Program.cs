using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            do
            {


                Console.Write("\nAnna kolme kokonaislukua: \n");
                a = int.Parse(Console.ReadLine());
              
                    Console.Write("\nAnna toinen luku: ");

                
                
                    Console.Write("Annoit luvun " + a);
                    Console.Write("\nAnna toinen luku: ");
                

                b = int.Parse(Console.ReadLine());
                
                    Console.Write("\nAnna kolmas luku: ");
                
                    Console.Write("Annoit luvun " + b);
                    Console.Write("\nAnna kolmas luku: ");
               

                c = int.Parse(Console.ReadLine());

                Console.Write("Annoit luvun " + c);


                Console.Write("\nSuurin luku = " + Math.Max(Math.Max(a, b), c), "\n");
                Console.Write("\nAnna luku 0 jos haluat lopettaa");
                Console.WriteLine();
            }
            while (a != 0); while (b != 0) ; while (c != 0) ;



        }
    }
}
