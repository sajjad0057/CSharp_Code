using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Generics
{
    internal class Container<T> where T : IItem
    {
        private T[] _items;
        private int _index;

        public Container(int length)
        {
            _items = new T[length];
            _index = 0;
        }

        public void AddItem(T item)
        {
            if (_index < _items.Length)
            {
                _items[_index++] = item;
            }
        }

        public T[] AllItems()
        {
            return _items;
        }
    }
}
