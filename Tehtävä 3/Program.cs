using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä 3
{
    class Program
{


    static void Main(string[] args)
    {



        int result1, result2, result3; //määritellään muuttujat
        int summa, keskiarvo;


        Console.WriteLine("Anna kolme lukua"); //Vastaa cout komentoa
                                               //Kysytään käyttäjältä luvut
        int.TryParse(Console.ReadLine(), out result1);
        int.TryParse(Console.ReadLine(), out result2);
        int.TryParse(Console.ReadLine(), out result3);



        summa = (result1 + result2 + result3); //laskee lukujen summan
        keskiarvo = (summa / 3); //laskee keskiarvon
        Console.WriteLine("Summa: " + summa + "\nKeskiarvo: " + keskiarvo); //kirjoittaa tulokset konsoliin


        Console.ReadLine();


    }
}

}