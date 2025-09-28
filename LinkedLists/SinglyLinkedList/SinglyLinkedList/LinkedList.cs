using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SinglyLinkedList
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Next;
        public LinkedList<T> parentList;

        public Node(T value, LinkedList<T> parentList)
        {
            this.Value = value;            
        }
        public Node(T value, Node<T> next, LinkedList<T> parentList)
        {
            Value = value;
            Next = next;
            this.parentList = parentList;
        }
    }
    public class LinkedList<T> 
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }

        //Constructors & Functions

        public LinkedList(T value)
        {
            Node<T> node = new Node<T>(value,this);
            Head = node;
            Tail = node;
            Count++;
        }

        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value, this);
            node.Next = Head;
            Head = node;
            Count++;
        }

        public void AddLast(T value)
        {
            Node<T> node = new Node<T>(value, this);
            Tail.Next = node;
            Tail = node;
            Count++;
        }

        public void AddBefore(Node<T> node, T value)
        {
            Node<T> temp = Head;

            if(node.Value.Equals(Head.Value))
            {
                Node<T> newHead = new Node<T>(value, this);

                newHead.Next = Head;
                newHead = Head;
                
                Count++;
                return;
            }

            while (!temp.Next.Value.Equals(node.Value))
            {
                temp = temp.Next;
            }

            Node<T> newNode = new Node<T>(value, this);
            Node<T> target = temp.Next;

            temp.Next = newNode;
            newNode.Next = target;
            Count++;
        }

        public void AddAfter(Node<T> node, T value)
        {
            Node<T> temp = Head;

            if (node.Value.Equals(Tail.Value))
            {
                Node<T> newTail = new Node<T>(value, this);

                Tail.Next = newTail;
                newTail = Tail;

                Count++;
                return;
            }

            while (!temp.Value.Equals(node.Value))
            {
                temp = temp.Next;
            }

            Node<T> newNode = new Node<T>(value, this);
            Node<T> target = temp.Next;

            temp.Next = newNode;
            newNode.Next = target;
            Count++;
        }

        public bool RemoveFirst()
        {
            if(Head.Equals(null))
            {
                return false;
            }
            else
            {
                Head = Head.Next;
                Count--;
                return true;
            }
        }

        public bool RemoveLast()
        {
            if (Tail.Equals(null))
            {
                return false;
            }
            else
            {
                Node<T> temp = Head;
                while (!temp.Next.Equals(Tail))
                {
                    temp = temp.Next;
                }

                Tail = temp;
                temp.Next = null;

                Count--;
                return true;
            }
        }

        public bool Remove(T value)
        {
            if(!this.Contains(value))
            {
                return false;
            }
            else
            {
                if (Head.Value.Equals(value))
                {
                    this.RemoveFirst();
                    Count--;
                    return true;
                }
                else if (Tail.Value.Equals(value))
                {
                    this.RemoveLast();
                    Count--;
                    return true;
                }

                Node<T> temp = Head;
                while (!temp.Next.Value.Equals(value))
                {
                    temp = temp.Next;
                }

                Node<T> prev = temp;
                Node<T> after = temp.Next.Next;

                prev.Next = after;
                Count--;
                return true;
            }
        }

        public void Clear()
        {
            Node<T> temp = Head;
            while (temp != null)
            {
                Node<T> toDelete = temp;
                temp = temp.Next;
                toDelete.Next = null;
            }
        }

        public Node<T> Search(T value)
        {
            if(!this.Contains(value))
            {
                return null;
            }
            else
            {
                Node<T> temp = Head;
                while (!temp.Value.Equals(value))
                {
                    temp = temp.Next;
                }

                return temp;
            }
        }

        public bool Contains(T value)
        {
            Node<T> temp = Head;
            while (!temp.Value.Equals(value))
            {
                temp = temp.Next;
                if (temp == null)
                {
                    return false;
                }
            }

            return true;
        }

        public bool Contains(Node<T> node)
        {
            return node.parentList == this;
        }
    }
}
