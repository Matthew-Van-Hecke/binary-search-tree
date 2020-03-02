using System;
using binarySearchTree;
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
            BinaryTree<Node> tree = new BinaryTree<Node>();
            int node = 12;
            //Act
            tree.Add(node);
            //Assert
            Assert.IsNotNull(tree.root);
        }
        [TestMethod]
        public void Add_OneIntNode_RootHasCorrectValue()
        {
            //Arrange
            BinaryTree<Node> tree = new BinaryTree<Node>();
            int node = 12;
            int expected = 12;
            //Act
            tree.Add(node);
            //Assert
            Assert.AreEqual(expected, tree.root.value);
        }
        [TestMethod]
        public void Add_FiveIntNodes_CountIsFive()
        {
            //Arrange
            BinaryTree<Node> tree = new BinaryTree<Node>();
            int node1 = 12;
            int node2 = 45;
            int node3 = 13;
            int node4 = 1;
            int node5 = 4;
            int expected = 5;
            //Act
            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);
            tree.Add(node4);
            tree.Add(node5);
            //Assert
            Assert.AreEqual(expected, tree.Count);
        }
        [TestMethod]
        public void Add_FiveIntNodes_node3IsInCorrectPosition()
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
            //Assert
            Assert.AreEqual(expected, tree.root.rightLink.leftLink.value);
        }
        [TestMethod]
        public void Add_FiveIntNodes_node5IsInCorrectPosition()
        {
            //Arrange
            BinaryTree<Node> tree = new BinaryTree<Node>();
            int node1 = 12;
            int node2 = 45;
            int node3 = 13;
            int node4 = 1;
            int node5 = 4;
            int expected = 4;
            //Act
            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);
            tree.Add(node4);
            tree.Add(node5);
            //Assert
            Assert.AreEqual(expected, tree.root.leftLink.rightLink.value);
        }
        //[TestMethod]
        //public void Search_SearchingForValueWhichIsInTree_ReturnValue()
        //{
        //    //Arrange
        //    BinaryTree<Node> tree = new BinaryTree<Node>();
        //    int node1 = 12;
        //    int node2 = 45;
        //    int node3 = 13;
        //    int node4 = 1;
        //    int node5 = 4;
        //    int expected = 4;
        //    //Act
        //    tree.Add(node1);
        //    tree.Add(node2);
        //    tree.Add(node3);
        //    tree.Add(node4);
        //    tree.Add(node5);
        //    //Assert
        //    Assert.AreEqual(expected, tree.root.leftLink.rightLink.value);
        //}
    }
}
