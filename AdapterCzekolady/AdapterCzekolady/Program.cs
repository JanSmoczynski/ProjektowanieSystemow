using System;
using AdapterCzekolady.Klasy;

namespace Adapter

{
    class Program
    {
        static void Main(string[] args)
        {
            Ciekle czekolada = new Ciekle();
            Stale target = new Zastyga(czekolada);

            Console.WriteLine("Nie jadalna płynna czekolada");
            Console.WriteLine("Lodówka pozwala na zmianę czekolady w tabliczki");

            Console.WriteLine(target.Akcja());
        }
    }
}