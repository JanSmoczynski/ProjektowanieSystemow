using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa.Klasy
{
    abstract class AbstractCV
    {
        public abstract void Imie();
        public abstract void Nazwisko();
        public abstract void Pesel();

        public void CVTemplate()
        {
            Console.WriteLine("\nImie:"); Imie();
            Console.WriteLine("Nazwisko:"); Nazwisko();
            Console.WriteLine("Pesel:"); Pesel();
            //Console.WriteLine("");
        }

    }
}
