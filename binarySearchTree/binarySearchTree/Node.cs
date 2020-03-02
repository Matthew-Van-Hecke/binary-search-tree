using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    public class Node<T> where T : IComparable
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
        public int CompareTo(Node<T> item)
        {
            return value.CompareTo(item.value);
        }
    }
}
