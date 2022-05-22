using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Examples
{
    public class BubbleSort<T>
    {
        public delegate int Compare(T x, T y);
        public static void Sort(T[] items, Compare compare)
        {
            for (int i = 0; i <= items.Length-2; i++)
            {
                for (int j = 0; j<= items.Length - 2; j++)
                {
                    if (compare(items[j] , items[j + 1]) == -1)
                    {
                        var temp = items[j + 1];
                        items[j + 1] = items[j];
                        items[j] = temp;
                    }
                } 
            }
        }
    }
}
