using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class Node<T>
    {
        //Member Variables
        public T value;
        public Node<T> leftLink;
        public Node<T> rightLink;
        //Constructor
        public Node(T value)
        {
            this.value = value;
        }
        //Member Methods
    }
}
