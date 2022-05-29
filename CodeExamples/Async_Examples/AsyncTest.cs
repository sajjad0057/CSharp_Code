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
                for (int i = 0; i <= 200; i += 2)
                {
                    Console.WriteLine(i);                   
                }
            });
        }

        public async Task PrintOddAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= 200; i += 2)
                {
                    Console.WriteLine(i);
                }
            });
        }

    }
}
