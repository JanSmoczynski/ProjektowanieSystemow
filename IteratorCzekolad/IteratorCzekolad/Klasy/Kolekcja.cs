using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorCzekolad.Klasy
{
    class Kolekcja : KolekcjaAbstrakcyjna
    {
        private ArrayList _marka = new ArrayList();

        public Iterator DodajIterator()
        {
            return new Iterator(this);
        }

        public int Licz
        {
            get { return _marka.Count; }
        }

        public object this[int index]
        {
            get { return _marka[index]; }
            set { _marka.Add(value); }
        }
    }
}
