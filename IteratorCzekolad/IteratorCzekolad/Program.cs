using IteratorCzekolad.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IteratorCzekolad
{
    class Program
    {
        static void Main(string[] args)
        {
            Kolekcja czekolady = new Kolekcja();

            czekolady[0] = new Marka("Wedel");
            czekolady[1] = new Marka("Milka");
            czekolady[2] = new Marka("Wawel");
            czekolady[3] = new Marka("Lint");
            czekolady[4] = new Marka("Nussbeisser");
            czekolady[5] = new Marka("Terravita");
            czekolady[6] = new Marka("Ritter");
            czekolady[7] = new Marka("Alpen Gold");
            czekolady[7] = new Marka("Deco Morreno");
            czekolady[7] = new Marka("Toblerone");

            Iterator iterator = czekolady.DodajIterator();

            Console.WriteLine("Przeszukanie Kolekcji:");

            for (Marka marka = iterator.Pierwsza();
                !iterator.Gotowe; marka = iterator.Kolejna())
            {
                Console.WriteLine(marka.Nazwa);
            }
            Console.WriteLine();
        }
    }
}
