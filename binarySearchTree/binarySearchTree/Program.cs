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
            Node node1 = new Node(12);
            Node node2 = new Node(45);
            Node node3 = new Node(13);
            Node node4 = new Node(1);
            Node node5 = new Node(4);
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
