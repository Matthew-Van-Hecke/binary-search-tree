using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    public class BinaryTree<T> where T : IComparable
    {
        //Member variables
        public Node<T> root;
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
        public void Add(T value)
        {
            Node<T> currentNode = root;
            Node<T> temporary = new Node<T>(value);
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
        public bool CurrentNodeIsLessThanNodeToAdd(ref Node<T> currentNode, ref Node<T> temporary)
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
        public bool CurrentNodeIsGreaterThanNodeToAdd(ref Node<T> currentNode, ref Node<T> temporary)
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
        public string Find(T value)
        {
            Node<T> currentNode = root;
            string path = "Value found at: root";
            string notFound = "Value not found.";
            while (currentNode != null)
            {
                if (currentNode.value.CompareTo(value) == 0)
                {
                    return path;
                }
                else if (currentNode.value.CompareTo(value) < 0)
                {
                    path += "-right";
                    currentNode = currentNode.rightLink;
                }
                else
                {
                    path += "-left";
                    currentNode = currentNode.leftLink;
                }
            }
            return notFound;
        }
    }
}
