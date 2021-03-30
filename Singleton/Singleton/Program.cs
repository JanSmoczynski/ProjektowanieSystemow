using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass singleton = SingletonClass.Instance;
            singleton.Jest = true;
            singleton.Nazwa = "Kłamca";

            Console.WriteLine(" Ksiązka pod tytułem  : " + singleton.Nazwa + "\n Czy najduje się w bazie : " + singleton.Jest + "\n");

            SingletonClass singleton2 = SingletonClass.Instance;
            singleton2.Jest = false;

            Console.WriteLine(" Ksiązka pod tytułem  : " + singleton2.Nazwa + "\n Czy najduje się w bazie : " + singleton2.Jest);

            Console.ReadKey();
        }
    }
}
