using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    public class BinaryTree<T>
    {
        //Member variables
        public Node root;
        private int count;
        public int Count
        {
            get { return count; }
        }
        //Constructor
        public BinaryTree()
        {
            count = 0;
        }
        //Member Methods
        public void Add(int value)
        {
            Node currentNode = root;
            Node temporary = new Node(value);
            if (root == null)
            {
                root = temporary;
                count++;
                return;
            }
            while (currentNode != null)
            {

                if (temporary.CompareTo(currentNode) <= 0)
                {
                    if(CurrentNodeIsLessThanNodeToAdd(ref currentNode, ref temporary))
                    {
                        return;
                    }
                }
                else
                {
                    if(CurrentNodeIsGreaterThanNodeToAdd(ref currentNode, ref temporary))
                    {
                        return;
                    }
                }
            }
        }
        public bool CurrentNodeIsLessThanNodeToAdd(ref Node currentNode, ref Node temporary)
        {
            if (currentNode.leftLink == null)
            {
                currentNode.leftLink = temporary;
                count++;
                return true;
            }
            else
            {
                currentNode = currentNode.leftLink;
            }
            return false;
        }
        public bool CurrentNodeIsGreaterThanNodeToAdd(ref Node currentNode, ref Node temporary)
        {
            if (currentNode.rightLink == null)
            {
                currentNode.rightLink = temporary;
                count++;
                return true;
            }
            else
            {
                currentNode = currentNode.rightLink;
            }
            return false;
        }
    }
}
