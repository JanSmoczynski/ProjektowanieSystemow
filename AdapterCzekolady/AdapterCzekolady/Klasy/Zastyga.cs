using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterCzekolady.Klasy
{
    class Zastyga : Stale
    {
        private readonly Ciekle _ciekle;

        public Zastyga(Ciekle ciekle)
        {
            this._ciekle = ciekle;
        }

        public string Akcja()
        {
            return $"'{this._ciekle.WybranaAkcja()}'";
        }
    }
}
