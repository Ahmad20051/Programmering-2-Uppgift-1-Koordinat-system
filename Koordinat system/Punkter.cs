using Punkter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace System1
{
    public class koordinatSystem
    {


        // här skapas det en ny random koordinat för x- och y-axeln
        Random rnd = new Random();
        int xKoordinat;
        int yKoordinat;

        // här skriver den ut 10 stycken olika korrdinater.
        public koordinatSystem()
        {
            Console.WriteLine("works");
            for (int a = 0; a < 10; a++)
            {

                // här printar den ut helt random koordinater mellan -10 och 10 för både x- och y-axeln.
                xKoordinat = rnd.Next(-10, 10);
                yKoordinat = rnd.Next(-10, 10);

                // här skriver den "dina två koordinater är: " och sedan visar den dina två random koordinater du får.
                Console.WriteLine("Dina två koordinater: ");
                Console.WriteLine("X-Koordinat: " + xKoordinat);
                Console.WriteLine("Y-Koordinat: " + yKoordinat);
            }
        }
    }
}