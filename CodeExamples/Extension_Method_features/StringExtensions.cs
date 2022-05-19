using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method_features
{
    public static class StringExtensions
    {
        public static int countVowel(this string originalString)
        {
            int count = 0;
            foreach (char c in originalString.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
