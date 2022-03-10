using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 if we doesnot set namespace here , then throw an exception ,
 for duplicate class name Product in same project folder.
 */

namespace PracticeNameSpace.SubModule
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
