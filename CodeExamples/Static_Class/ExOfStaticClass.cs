using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    internal static class ExOfStaticClass
    {
        public static void printArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
        }


        public static void print2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
            }
        }
    }
}
