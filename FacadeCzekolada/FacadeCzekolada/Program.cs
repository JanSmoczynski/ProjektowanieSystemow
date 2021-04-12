using FacadeCzekolada.klasy;
using System;

namespace FacadeCzekolada
{
    class Program
    {
        static void Main(string[] args)
        {
            CzekoladowaFacade facade = new CzekoladowaFacade();

            facade.TworzenieCzekolady();
            Console.ReadKey();
        }
    }
}
