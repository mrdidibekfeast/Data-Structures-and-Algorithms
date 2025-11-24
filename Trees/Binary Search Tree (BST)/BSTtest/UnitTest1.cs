using Binary_Search_Tree__BST_;
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

            Assert.True(BST.Search(4) != null);
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

    }
}