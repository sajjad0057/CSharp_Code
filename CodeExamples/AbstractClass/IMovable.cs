using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public interface IMovable
    {
        void Move();

        /*
        // Since C# 8 version, Interface can contain implementation of Signature if needed .
        // Implemented signature work as default . and Interface could not suggest or override this implemented 
           Singnature or method in child class .
        // 
        // 
         
         */

        public void Stop()
        {
            Console.WriteLine("Sotpping from interface");
        }


    }
}
