﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Classes
{
    class Milka : IFactory
    {
        public void Cocoa(int percent)
        {
            Console.WriteLine("Kakao w czekoladzie Milka : " + percent.ToString() + "%");
        }
    }
}
