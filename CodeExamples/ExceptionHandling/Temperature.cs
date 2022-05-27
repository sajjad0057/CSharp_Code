using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Temperature
    {
        private int _temperature;

        public Temperature(int temp)
        { 
            _temperature = temp;
        }
        public  void  showTemp()
        {

            if (_temperature == 0)
            {
                throw new TempIsZeroException("Zero Temperature found");
            }
            else
            {
                Console.WriteLine("Temperature: {0}", _temperature);
            }
        }

    }
}
