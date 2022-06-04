using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class Car
    {
        public string Color { get; set; }
        public string Model { get; set; }
        public IEngine Engine { get; set; }

        public Car(IEngine engine)
        {
            Engine = engine;
        }

        public void Start()
        {
            Engine.Ignite();
        }
    }
}
