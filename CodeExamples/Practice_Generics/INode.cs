using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Generics
{
    internal interface INode<item,iNode>
    {
        void Add(item item);
        void Remove(item item);
    }
}
