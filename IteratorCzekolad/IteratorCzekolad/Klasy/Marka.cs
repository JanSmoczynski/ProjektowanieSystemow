using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorCzekolad.Klasy
{
    class Marka
    {
        private string _nazwa;

        public Marka(string nazwa)
        {
            this._nazwa = nazwa;
        }

        public string Nazwa
        {
            get { return _nazwa; }
        }
    }
}
