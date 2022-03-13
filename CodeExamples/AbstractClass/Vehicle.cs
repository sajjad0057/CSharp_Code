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




        private double fuel;
        
        
        // AbstractClass can contain Constractor . 

        public Vehicle()
        {
            fuel = 0;
        }

        public abstract void StratEngine();



        public abstract void StopEngine();


    }
}
