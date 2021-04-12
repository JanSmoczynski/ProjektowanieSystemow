using MetodaSzablonowa.Klasy;
using System;

namespace MetodaSzablonowa
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCV a1 = new ConceretCv1();
            a1.CVTemplate();

            AbstractCV a2 = new ConceretCv2();
            a2.CVTemplate();

            Console.ReadKey();
        }
    }
}
