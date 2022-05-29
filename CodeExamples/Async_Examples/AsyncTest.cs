using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Examples
{
    public class AsyncTest
    {

        public void PrintEven()
        {
            for (int i = 0; i <= 200; i+=2)
            {
                Console.WriteLine(i);
            }
        }

        public void PrintOdd()
        {
            for (int i = 1; i <= 200; i+=2)
            {
                Console.WriteLine(i);
            }
        }

    }
}
