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
            BinaryTree<int> tree = new BinaryTree<int>();
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
            BinaryTree<int> tree = new BinaryTree<int>();
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
            BinaryTree<int> tree = new BinaryTree<int>();
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
            BinaryTree<int> tree = new BinaryTree<int>();
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
            BinaryTree<int> tree = new BinaryTree<int>();
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
        [TestMethod]
        public void Find_SearchingForValueWhichIsInTree_ReturnFilePathOfValue()
        {
            //Arrange
            BinaryTree<int> tree = new BinaryTree<int>();
            int node1 = 12;
            int node2 = 45;
            int node3 = 13;
            int node4 = 1;
            int node5 = 4;
            string expected = "Value found at: root-left-right";
            string actual;
            //Act
            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);
            tree.Add(node4);
            tree.Add(node5);
            actual = tree.Find(4);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Find_SearchingForValueWhichIsNotInTree_ReturnStringSayingThatValueIsNotInTree()
        {
            //Arrange
            BinaryTree<int> tree = new BinaryTree<int>();
            int node1 = 12;
            int node2 = 45;
            int node3 = 13;
            int node4 = 1;
            int node5 = 4;
            string expected = "Value not found.";
            string actual;
            //Act
            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);
            tree.Add(node4);
            tree.Add(node5);
            actual = tree.Find(6);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Find_SearchingForIntValueWhichIsInTree_ReturnPathToValueInTree()
        {
            //Arrange
            BinaryTree<int> tree = new BinaryTree<int>();
            int node1 = 12;
            int node2 = 45;
            int node3 = 13;
            int node4 = 1;
            int node5 = 4;
            int node6 = 78;
            int node7 = 98;
            int node8 = 100;
            string expected = "Value found at: root-right-right-right-right";
            string actual;
            //Act
            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);
            tree.Add(node4);
            tree.Add(node5);
            tree.Add(node6);
            tree.Add(node7);
            tree.Add(node8);
            actual = tree.Find(100);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Find_SearchingForStringValueWhichIsInTree_ReturnPathToValueInTree()
        {
            //Arrange
            BinaryTree<string> tree = new BinaryTree<string>();
            string node1 = "Bob";
            string node2 = "Hank";
            string node3 = "Harry";
            string node4 = "Michael";
            string node5 = "Nevin";
            string node6 = "David";
            string node7 = "Charles";
            string node8 = "Paul";
            string expected = "Value found at: root-right-right-right-right-right";
            string actual;
            //Act
            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);
            tree.Add(node4);
            tree.Add(node5);
            tree.Add(node6);
            tree.Add(node7);
            tree.Add(node8);
            actual = tree.Find("Paul");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
