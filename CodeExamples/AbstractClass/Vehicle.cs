using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Vehicle
    {
        public int PassengerCount { get; set; }
        public double Speed { get; set; }

        public abstract void StratEngine();



        public abstract void StopEngine();


    }
}
