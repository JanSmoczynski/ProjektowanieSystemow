using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa.Klasy
{
    class ConceretCv1 : AbstractCV
    {
        public override void Imie()
        {
            Console.WriteLine(" Jan");
        }
        public override void Nazwisko()
        {
            Console.WriteLine(" Smoczyński");
        }
        public override void Pesel()
        {
            Console.WriteLine(" 36400");
        }
    }
}
