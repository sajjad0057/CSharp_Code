using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Important_BuiltIn_Interface
{
    public class Box : IEnumerable<object>
    {
        public object[] _items;

        public IEnumerator<object> GetEnumerator()    // it's implementations for General purpose 
        {
            return new BoxEnumerator(_items);
        }

        IEnumerator IEnumerable.GetEnumerator()   // it's implementation for IEnumerable interface 
        {
            return GetEnumerator();
        }
    }
}
