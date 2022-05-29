using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Examples
{
    public class AsyncTest
    {
        /// <summary>
        /// Examples of Asynchronous code , Asynchronous code are executed parallely and next code will not waiting untill finishing previous code executions .
        /// All codes executions are doing parallely , 
        /// </summary>
        public async Task PrintEvenAsync()
        {   
            await Task.Run(() =>
            { 
                    Thread.Sleep(5000);
            });

            Console.WriteLine("PrintEvenAsync executed ! , here Thread Sleep 5 sec");
        }
        public async Task PrintOddAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
            });

            Console.WriteLine("PrintEvenAsync executed ! , here Thread Sleep 3 sec");
        }

    }
}
