using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punkter
{

    // Programmet generera 10 punkter och skriver ut alla punkters koordinater. 
    public class Punkt
    {
        // Skapar en siffra (int) för x- och y-koordinaten och är private så att det bara används i denna funktion och inte andra
        private int xKoordinat = 0;
        private int yKoordinat = 0;

        // Skapar en random punkt i koordinat systemet och returnerar den
        public int getX() { return this.xKoordinat; }
        public int getY() { return this.yKoordinat; }

        //Den voidar att man ska kunna sätta en egen punkt
        public void setX(int x) { this.xKoordinat = x; }
        public void setY(int y) { this.yKoordinat = y; }

        // Fördjupning: 1
        // Säkerställer att punkterna inte hamnar på samma position, d.v.s., inga “dubletter”. 
        public void IncreaseX()
        {
            // Kommer en punkt på samma ställe så adderar den siffran med 1
            this.xKoordinat += 1;
        }
        public void IncreaseY()
        {
            // Kommer en punkt på samma ställe så subtraherar den siffran med 1
            this.yKoordinat -= 1;
        }
    }
}

// Fördjupning: 2
// Se till att alla funktioner kan ta argument som ändrar antalet punkter, d.v.s.:
// genereraPunkter(antal) , där antalet som anges som argument är antalet punkter som genereras
public class genereraPunkter
{
    public genereraPunkter()
    {
        // Frågor hur många koordinater den ska printa ut
        Console.WriteLine("Skriv en siffra: ");

        // Läser av hur många koordinater man svarade med
        string antalSiffror = Console.ReadLine();
        int g = 0;
        g = int.Parse(antalSiffror);

        // Skapar en ny koordinat för ditt svar
        Random rnd = new Random();
        int xKordinat;
        int yKordinat;

        for (int a = 0; a < g; a++)
        {
            // Här skapas din egna koordinat mellan -10 och 10
            xKordinat = rnd.Next(-10, 10);
            yKordinat = rnd.Next(-10, 10);
            Console.WriteLine("(" + yKordinat + "," + xKordinat + ")");
            Console.WriteLine(" ");
        }
    }
}