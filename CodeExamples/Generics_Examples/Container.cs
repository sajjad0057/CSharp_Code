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

        private int index;

        public Container()
        {
            _items = new T[10];
            index = 0;
        }
        public void AddItem(T item)
        {
            if (index < _items.Length)
            {
                _items[index++] = item;
            }
        }
    }
}
