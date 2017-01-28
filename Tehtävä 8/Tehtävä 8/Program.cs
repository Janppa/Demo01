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
            int a,b,c;
             
            {

                Console.Write("Anna kolme kokonaislukua: \n");
                a = int.Parse(Console.ReadLine());
                if (a == 0) { 
                    Console.Write("Kielletty numero");
                    Console.Write("\nAnna toinen luku: ");
                   
                }
                else {
                    Console.Write("Annoit luvun " + a);
                    Console.Write("\nAnna toinen luku: ");
                }
                
                    b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    Console.Write("Kielletty numero");
                    Console.Write("\nAnna kolmas luku: ");
                }
                else
                {
                    Console.Write("Annoit luvun " + b);
                    Console.Write("\nAnna kolmas luku: ");
                }

                c = int.Parse(Console.ReadLine());
                if (c == 0)
                {
                    Console.Write("Kielletty numero");
                }
                else
                {
                    Console.Write("Annoit luvun " + c);
                }
                    }
                Console.Write("\nSuurin luku = " + Math.Max(Math.Max(a, b), c), "\n");
            Console.WriteLine();
            }
        
        


        }
    }
