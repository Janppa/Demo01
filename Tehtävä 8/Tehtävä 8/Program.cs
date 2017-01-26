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
            int a,b,c;
            
            Console.Write("Anna 3 kokonaislukua: \n");
            a = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Suurin luku = " + Math.Max(Math.Max(a, b), c));
            


        }
    }
}
