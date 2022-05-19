using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method_features
{
    public static class ListExtensions
    {
        public static (List<T> a , List<T> b) Split<T>(this List<T> originalList)
        {
            List<T> item1 = new List<T> ();
            List<T> item2 = new List<T> ();

            for (int i = 0; i < originalList.Count/2; i++)
            {
                item1.Add(originalList[i]);
            }

            for (int i = originalList.Count / 2; i < originalList.Count; i++)
            {
                item2.Add(originalList[i]);
            }

            return (item1, item2);
        }
    }
}



