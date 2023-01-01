using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.CreationalDesignPatterns.AbstractFactory
{
    public class ToyotaCarFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new ToyotaEngine();
        }

        public ITire CreateTier()
        {
            return new ToyotaTire();
        }
    }
}
