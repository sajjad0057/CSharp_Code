using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    public class Waterbottle
    {
        public string color;
        public static int count;

        public Waterbottle()
        {
            count++;
        }  

    }
}
