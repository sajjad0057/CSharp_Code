using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Finalizer
{
    internal class Clock
    {
        public DateTime currentTime;

        public Clock()
        {
            currentTime = DateTime.MinValue;
        }


        ~Clock()      //finalizer
        {
            currentTime = DateTime.MaxValue;
            
            
        }
    }
}
