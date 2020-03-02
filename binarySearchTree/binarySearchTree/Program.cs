using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrange
            BinaryTree<Node> tree = new BinaryTree<Node>();
            int node1 = 12;
            int node2 = 45;
            int node3 = 13;
            int node4 = 1;
            int node5 = 4;
            int expected = 13;
            //Act
            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);
            tree.Add(node4);
            tree.Add(node5);
            int actual = tree.root.rightLink.value;
            //Assert
            Console.ReadLine();
        }
    }
}
