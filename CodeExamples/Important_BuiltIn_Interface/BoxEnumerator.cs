using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Important_BuiltIn_Interface
{
    internal class BoxEnumerator : IEnumerator<object>
    {

        private object[] _items;
        private int _index;

        public BoxEnumerator(object[] items)
        {
            _items = items;
            _index = -1;
        }
        public object Current => _items[_index];   // using lambda expression , here Current is a proparty, arrow syntax might be used as get , set func . 

        public void Dispose()    // that's cominng from IDisposable interface, becasue IEnumerator implement IDisposable interface . 
        {
            _items = null;
            _index--;
            //Reset();
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _items.Length;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
