using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorCzekolad.Klasy
{
    class Iterator : AbstrakcyjnyIterator
    {
        private Kolekcja _kolekcja;
        private int _obecna = 0;

        public Iterator(Kolekcja kolekcja)
        {
            this._kolekcja = kolekcja;
        }

        public Marka Pierwsza()
        {
            _obecna = 0;
            return _kolekcja[_obecna] as Marka;
        }

        public Marka Kolejna()
        {
            _obecna += 1;
            if (!Gotowe)
                return _kolekcja[_obecna] as Marka;
            else
                return null;
        }

        public Marka ObecnaMarka
        {
            get { return _kolekcja[_obecna] as Marka; }
        }

        public bool Gotowe
        {
            get { return _obecna >= _kolekcja.Licz; }
        }
    }
}
