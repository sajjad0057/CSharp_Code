using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Generics
{
    public interface INode<T,Q> 
        where T : class 
        where Q : INode<T,Q>
    {
        void Add(T item);
        void Remove(Q item);
    }
}
