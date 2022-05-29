using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Examples
{
    public class AsyncTest
    {

        public async Task PrintEven()
        {
            //// using async keyword, declare a method as asynchronous and in this method accept a logic under Task.Run()  method .
            
            Task.Run(() =>
            {
                for (int i = 0; i <= 200; i += 2)
                {
                    Console.WriteLine(i);
                }

            });

        }

        public async Task PrintOdd()
        {
            Task.Run(() =>
            {
                for (int i = 1; i <= 200; i += 2)
                {
                    Console.WriteLine(i);
                }
            });
        }

    }
}
