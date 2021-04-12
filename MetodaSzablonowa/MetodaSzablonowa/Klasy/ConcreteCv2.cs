using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa.Klasy
{
    class ConceretCv2 : AbstractCV
    {
        public override void Imie()
        {
            Console.WriteLine(" Dominika");
        }
        public override void Nazwisko()
        {
            Console.WriteLine(" Andrzejewska");
        }
        public override void Pesel()
        {
            Console.WriteLine(" 36447");
        }
    }
}
