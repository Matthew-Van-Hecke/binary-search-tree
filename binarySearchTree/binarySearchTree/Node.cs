using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class Node
    {
        //Member Variables
        public int value;
        public Node leftLink;
        public Node rightLink;
        //Constructor
        public Node(int value)
        {
            this.value = value;
        }
        //Member Methods
        public int CompareTo(Node item)
        {
            return value.CompareTo(item.value);
        }
    }
}
