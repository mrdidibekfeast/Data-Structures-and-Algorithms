using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree__BST_
{
    public class Node<T>
    {
        public Node<T> Left { get; set; } //Instead of Next
        public Node<T> Right { get; set; } //Instead of Previous

        public T Value { get; set; }

        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
            
        }
    }

    public class BinarySearchTree <T> where T : IComparable<T>
    {
        public Node<T> root { get; private set; }
        private int Count;
        
        public BinarySearchTree()
        {
            root = null;
            Count = 0;
        }

        public bool Insert(T value)
        {
            if(root == null)
            {
                root = new Node<T>(value);
                Count++;
                return true;
            }
            else
            {
                Node<T> currNode = root;
                while (true)
                {
                    if (value.CompareTo(currNode.Value) < 0)
                    {
                        if (currNode.Left != null)
                        {
                            currNode = currNode.Left;
                        }
                        else
                        {
                            currNode.Left = new Node<T>(value);
                            Count++;
                            return true;
                        }
                    }
                    else if (value.CompareTo(currNode.Value) > 0)
                    {
                        if (currNode.Right != null)
                        {
                            currNode = currNode.Right;
                        }
                        else
                        {
                            currNode.Right = new Node<T>(value);
                            Count++;
                            return true;
                        }
                    }
                    else if (value.CompareTo(currNode.Value) == 0)
                    {
                        return false;
                    }
                }
            }
        }
        public Node<T> Search(T value)
        {
            if(root == null)
            {
                return null;
            }
            else
            {
                Node<T> currNode = root;
                while(true)
                {
                    if(value.CompareTo(currNode.Value) < 0)
                    {   
                        if(currNode.Left == null)
                        {
                            return null;
                        }
                        else
                        {
                            currNode = currNode.Left;
                        }
                    }
                    else if(value.CompareTo(currNode.Value) > 0)
                    {
                        if (currNode.Right == null)
                        {
                            return null;
                        }
                        else
                        {
                            currNode = currNode.Right;
                        }
                    }
                    else
                    {
                        return currNode;
                    }   
                }
            }
        }
        public bool Contains(T value)
        {
            if (root == null)
            {
                return false; 
            }
            else
            {
                Node<T> currNode = root;
                while (true)
                {
                    if (value.CompareTo(currNode.Value) < 0)
                    {
                        if (currNode.Left == null)
                        {
                            return false;
                        }
                        else
                        {
                            currNode = currNode.Left;
                        }
                    }
                    else if (value.CompareTo(currNode.Value) > 0)
                    {
                        if (currNode.Right == null)
                        {
                            return false;
                        }
                        else
                        {
                            currNode = currNode.Right;
                        }
                    }
                    else
                    {
                        return true; ;
                    }
                }
            }
        }
        public T Minimum()
        {
            if (root == null)
            {
                throw new Exception("Empty Tree");
            }
            else
            {
                Node<T> currNode = root;
                while (currNode.Left != null)
                {
                    currNode = currNode.Left;
                }
                return currNode.Value;
            }
        }
        public T Maximum()
        {
            if (root == null)
            {
                throw new Exception("Empty Tree");
            }
            else
            {
                Node<T> currNode = root;
                while (currNode.Right != null)
                {
                    currNode = currNode.Right;
                }
                return currNode.Value;
            }
        }

        public List<T> LevelOrder()
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            Node<T> currNode = root;
            List<T> nums = new List<T>();

            if(currNode == null)
            {
                return new List<T>();
            }
            else
            {
                queue.Enqueue(currNode);
                while(queue.Count > 0)
                {
                    currNode = queue.Dequeue();
                    nums.Add(currNode.Value);
                    if(currNode.Left != null)
                    {
                        queue.Enqueue(currNode.Left);
                    }
                    if (currNode.Right != null)
                    {
                        queue.Enqueue(currNode.Right);
                    }

                }

                return nums;
            }
        }

        public List<T> preOrder()
        {
            Stack<Node<T>> stack = new Stack<Node<T>>();
            Node<T> currNode = root;
            List<T> nums = new List<T>();

            if (currNode == null)
            {
                return new List<T>();
            }
            else
            {
                stack.Push(currNode);
                while (stack.Count > 0)
                {
                    currNode = stack.Pop();
                    nums.Add(currNode.Value);
                    if (currNode.Right != null)
                    {
                        stack.Push(currNode.Right);
                    }
                    if (currNode.Left != null)
                    {
                        stack.Push(currNode.Left);
                    }
                }

                return nums;
            }

        }
    }
}
