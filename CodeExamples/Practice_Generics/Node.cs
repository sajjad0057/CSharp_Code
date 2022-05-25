using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Generics
{
    public class Node<T, Q>  : NodeBase<T,Q> 
        where T : class
        where Q : INode<T,Q>
    {

    }
}
