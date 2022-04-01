using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Examples
{
    internal class Container<T>  where T : IItem      /// set contrain as IItem interface  . 
     {

        public T[] _items;    // declare T typed array 

        private int _index;

        public Container()
        {
            _items = new T[10];
            _index = 0;
        }
        public void AddItem(T item)
        {
            if (_index < _items.Length)
            {
                _items[_index++] = item;
            }
        }

        public T? GetItem(int index)
        {
            if (index < _index)
                return _items[_index++];
            else 
                return default(T);            // default(dataType);  return default value of passed dataTyped. 
        }
    }
}
