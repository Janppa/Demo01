using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_1
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Anna numero 1-3.");

            int result;

            if (int.TryParse(Console.ReadLine(), out result))

            {

                if (result == 1)

                    Console.WriteLine("Lukusi on yksi");

                else if (result == 2)

                    Console.WriteLine("Lukusi on kaksi");
                else if (result == 3)

                    Console.WriteLine("Lukusi on kolme ");
                else

                    Console.WriteLine("joku muu luku");
                Console.ReadLine();

            }



        }

    }