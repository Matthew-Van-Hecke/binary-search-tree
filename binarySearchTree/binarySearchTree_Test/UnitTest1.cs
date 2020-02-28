using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace binarySearchTree_Test
{
    [TestClass]
    public class Binary_Tree_Test
    {
        [TestMethod]
        public void Add_OneIntNode_RootInNotNull()
        {
            //Arrange
            BinaryTree<Node<int>> tree = new BinaryTree<Node<int>>();
            Node<int> node = new Node<int>(12);
            //Act
            tree.Add(node);
            //Assert
            Assert.IsNotNull(tree.root);
        }
        [TestMethod]
        public void Add_OneIntNode_RootHasCorrectValue()
        {
            //Arrange
            BinaryTree<Node<int>> tree = new BinaryTree<Node<int>>();
            Node<int> node = new Node<int>(12);
            int expected = 12;
            //Act
            tree.Add(node);
            //Assert
            Assert.AreEqual(expected, tree.root.value);
        }
    }
}
