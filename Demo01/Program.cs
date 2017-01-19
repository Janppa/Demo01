using System;
namespace Demo01
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Anna pisteesi");

            int result;

            if (int.TryParse(Console.ReadLine(), out result))

            {

                if (result == 0 || result == 1)

                    Console.WriteLine("Numerosi on 0");

                else if (result ==2 || result ==3)

                    Console.WriteLine("Numerosi on ");
                else if (result == 4 || result == 5)

                    Console.WriteLine("Numerosi on 2");

                else if (result == 6 || result == 7)

                    Console.WriteLine("Numerosi on 3");

                else if (result == 8 || result == 9)

                    Console.WriteLine("Numerosi on 4");

                else if (result == 10 || result == 11 || result == 12)

                    Console.WriteLine("Numerosi on 5");

                else

                    Console.WriteLine("Joku muu luku");
                Console.ReadLine();

            }


        }
    }
    
}