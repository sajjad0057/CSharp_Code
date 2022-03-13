using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Bus : Vehicle , IMovable
    {


        public override void StratEngine()
        {

        }


        public override void StopEngine()
        {

        }

        public void StartHeadLight()
        {

        }

        public void Move()
        {
            Console.WriteLine("Move from Bus");
        }

        public void Stop()
        {
            Console.WriteLine("Stop from Bus");
        }
    }
}
