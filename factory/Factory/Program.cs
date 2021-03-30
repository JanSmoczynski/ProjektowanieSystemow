using Factory.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocoFactory factory = new ConcreteChocoFactory();

            IFactory milka = factory.GetChoco("Milka");
            milka.Cocoa(60);

            IFactory wedel = factory.GetChoco("Wedel");
            wedel.Cocoa(70);
            Console.ReadKey();

        }
    }
}
