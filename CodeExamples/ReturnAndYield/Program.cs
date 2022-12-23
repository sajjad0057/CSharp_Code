
/*
 Yield keyword helps to do custom stateful iteration over a collection. 
 Meaning when we use yield keyword the control moves back and forth from 
 the caller function to source and vice versa.
 */





using System;
using System.Collections.Generic;
namespace DemoApplication
{
    class Program
    {
        static List<int> numbersList = new List<int> {
         1, 2, 3, 4, 5
      };
        public static void Main()
        {
            foreach (int i in RunningTotal())
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        public static IEnumerable<int> RunningTotal()
        {
            int runningTotal = 0;
            foreach (int i in numbersList)
            {
                runningTotal += i;
                yield return (runningTotal);
            }
        }
    }
}