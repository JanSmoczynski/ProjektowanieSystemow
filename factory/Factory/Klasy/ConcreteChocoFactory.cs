using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Classes
{
    class ConcreteChocoFactory : ChocoFactory
    {
        public override IFactory GetChoco(string Choco) 
        {
            switch (Choco)
            {
                case "Milka":
                    return new Milka();

                case "Wedel":
                    return new Wedel();

                default:
                    throw new ApplicationException(string.Format("Chocolate '{0}' cannot be created", Choco));

            }
        }
    }
}
