using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Classes
{
    abstract class ChocoFactory
    {
        public abstract IFactory GetChoco(string Chocko);
    }
}
