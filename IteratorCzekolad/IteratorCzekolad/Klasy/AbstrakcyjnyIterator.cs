using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorCzekolad.Klasy
{
    interface AbstrakcyjnyIterator
    {
        Marka Pierwsza();
        Marka Kolejna();
        bool Gotowe { get; }
        Marka ObecnaMarka { get; }
    }
}
