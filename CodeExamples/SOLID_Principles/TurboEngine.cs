﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class TurboEngine : IEngine
    {
        public void Ignite()
        {
            Console.WriteLine("Car Started With Turbo Engine !");
        }
    }
}
