using Binary_Search_Tree__BST_;
using System.Net;
namespace BSTtest
{
    public class UnitTest1
    {
        [Fact]
        public void InsertTest()
        {
            BinarySearchTree<int> BST = new BinarySearchTree<int>();
            for (int i = 0; i < 5; i++)
            {
                BST.Insert(i);
            }
            Node<int> currentNode = BST.root;
            for (int i = 0; i < 5; i++)
            { 
                Assert.True(currentNode.Value == i);
                currentNode = currentNode.Right;
            }



            BinarySearchTree<int> BST2 = new BinarySearchTree<int>();
            for (int i = 5; i >= 0; i--)
            {
                BST2.Insert(i);
            }
            currentNode = BST2.root;
            for (int i = 5; i >= 0; i--)
            {
                Assert.True(currentNode.Value == i);
                currentNode = currentNode.Left;
            }

        }

        [Fact]
        public void SearchTest()
        {
            BinarySearchTree<int> BST = new BinarySearchTree<int>();

            Assert.True(BST.Search(4) == null);

            for (int i = 0; i < 5; i++)
            {
                BST.Insert(i);
            }

            Assert.True(BST.Search(4).Value == 4);
            Assert.True(BST.Search(7) == null);
        }

        [Fact]
        public void ContainsTest()
        {
            BinarySearchTree<int> BST = new BinarySearchTree<int>();

            Assert.True(BST.Contains(4) == false);

            for (int i = 0; i < 5; i++)
            {
                BST.Insert(i);
            }

            Assert.True(BST.Contains(4) != false);
            Assert.True(BST.Contains(7) == false);
        }


        [Fact]
        public void MaxMinTest()
        {
            BinarySearchTree<int> BST = new BinarySearchTree<int>();
            for (int i = 0; i < 5; i++)
            {
                BST.Insert(i);
            }

            Assert.True(BST.Maximum() == 4);
            Assert.True(BST.Minimum() == 0);


            BinarySearchTree<int> BST2 = new BinarySearchTree<int>();
            for (int i = 5; i >= 0; i--)
            {
                BST2.Insert(i);
            }

            Assert.True(BST.Maximum() == 4);
            Assert.True(BST.Minimum() == 0);
        }


        [Fact]
        public void LevelOrderTest()
        {
            BinarySearchTree<int> BST = new BinarySearchTree<int>();
            BST.Insert(6);
            BST.Insert(2);
            BST.Insert(8);
            BST.Insert(1);
            BST.Insert(4);
            BST.Insert(7);
            BST.Insert(9);
            BST.Insert(3);
            BST.Insert(5);
            BST.Insert(10);

            List<int> traverse = BST.LevelOrder();
            List<int> levelOrder = [6,2,8,1,4,7,9,3,5,10];

            Assert.Equal(traverse[2], levelOrder[2]);
        }

        [Fact]
        public void PreOrderTest()
        {
            BinarySearchTree<int> BST = new BinarySearchTree<int>();
            BST.Insert(6);
            BST.Insert(2);
            BST.Insert(8);
            BST.Insert(1);
            BST.Insert(4);
            BST.Insert(7);
            BST.Insert(9);
            BST.Insert(3);
            BST.Insert(5);
            BST.Insert(10);

            List<int> traverse = BST.preOrder();
            List<int> preOrder = [6,2,1,4,3,5,8,7,9,10];

            Assert.Equal(traverse[2], preOrder[2]);
        }
    }
}