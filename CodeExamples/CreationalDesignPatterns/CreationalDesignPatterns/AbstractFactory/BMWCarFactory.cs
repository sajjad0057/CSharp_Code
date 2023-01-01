using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.CreationalDesignPatterns.AbstractFactory
{
    public class BMWCarFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new BMWEngine();
        }

        public ITire CreateTier()
        {
            return new BMWTire();
        }
    }
}
