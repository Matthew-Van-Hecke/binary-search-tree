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
        public void Add(Node node)
        {
            Node currentNode = root;
            Node temporary = new Node(node.value);
            if (root == null)
            {
                root = temporary;
                count++;
                return;
            }
            //If there are Nodes in the list already, compare temporary node with each, and put a link to it once its right position is found.
            while (currentNode != null)
            {

                if (temporary.CompareTo(currentNode) <= 0)
                {
                    if (currentNode.leftLink == null)
                    {
                        currentNode.leftLink = temporary;
                        count++;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.leftLink;
                    }
                }
                else
                {
                    if (currentNode.rightLink == null)
                    {
                        currentNode.rightLink = temporary;
                        count++;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.rightLink;
                    }
                }
            }
            
        }
    }
}
