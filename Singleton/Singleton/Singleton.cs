using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonClass
    {
        private static SingletonClass instance = new SingletonClass();

        private bool jest;
        private string nazwa;

        private SingletonClass() { }

        internal static SingletonClass Instance
        {
            get => instance;
            set => instance = value;
        }

        public bool Jest { get => jest; set => jest = value; }
        public string Nazwa { get => nazwa; set => nazwa = value; }


    }
}
