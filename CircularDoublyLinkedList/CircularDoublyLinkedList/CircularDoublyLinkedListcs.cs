
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularDoublyLinkedList
{
    class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }
        public DoublyLinkedList<T> Owner { get; internal set; }
        public T Value { get; set; }

        public DoublyLinkedListNode(T value, DoublyLinkedList<T> owner)
        {
            Value = value;
            Next = null;
            Previous = null;
            Owner = owner;
        }
    }

    class DoublyLinkedList<T>
    {
        public int Count { get; private set; }  
        public DoublyLinkedListNode<T> Head { get; private set; }
        public DoublyLinkedListNode<T> Tail { get; private set; }

        public DoublyLinkedList()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }


        public void AddFirst(T value)
        {
            if(Count == 0)
            {
                DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(value, this);
                newNode.Next = newNode;
                newNode.Previous = newNode;

                Head = newNode;
                Tail = newNode;

                Count++;
                return;
            }

            DoublyLinkedListNode<T> temp = new DoublyLinkedListNode<T>(value, this);
            temp.Next = Head;
            temp.Previous = Tail;
            Tail.Next = temp;
            Head.Previous = temp;
            Head = temp;
            Count++;
        }


        public void AddLast(T value)
        {
            if (Count == 0)
            {
                DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(value, this);
                newNode.Next = newNode;
                newNode.Previous = newNode;

                Head = newNode;
                Tail = newNode;

                Count++;
                return;
            }

            DoublyLinkedListNode<T> temp = new DoublyLinkedListNode<T>(value, this);
            temp.Next = Head;
            temp.Previous = Tail;
            Tail.Next = temp;
            Head.Previous = temp;
            Tail = temp;
            Count++;
        }

        public void AddAfter(DoublyLinkedListNode<T> node, T value)
        {
            if (!Contains(node)) return;

            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(value, this);
            if (node == Head)
            {
                newNode.Next = Head.Next;
                Head.Next.Previous = newNode;
                Head.Next = newNode;
                newNode.Previous = Head;
                return;
            }
            else if (node == Tail)
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Head.Previous = newNode;
                newNode.Next = Head;
                Tail = newNode;
            }
            else
            {
                DoublyLinkedListNode<T> temp = Head.Next;
                while (temp != node)
                {
                    temp = temp.Next;
                }

                temp.Next.Previous = newNode;
                newNode.Next = temp.Next;
                temp.Next = newNode;
                newNode.Previous = temp;
               
            }
        }

        
        public bool RemoveFirst()
        {
            if(Count == 0)
            {
                return false;
            }
            else if (Count == 1)
            {
                Head = null;
                Tail = null;
                Count--;
                return true;
            }
            else
            {
                DoublyLinkedListNode<T> temp = Head.Next;
                Head.Next = null;
                Head.Previous = null;
                Tail.Next = temp;
                temp.Previous = Tail;
                Head = temp;
                Count--;
                return true;
            }
        }
       
        public bool RemoveLast()
        {
            if (Count == 0)
            {
                return false;
            }
            else if (Count == 1)
            {
                Head = null;
                Tail = null;
                Count--;
                return true;
            }
            else
            {
                DoublyLinkedListNode<T> temp = Tail.Previous;
                Head.Previous = temp;
                temp.Next = Head;
                Tail = temp;
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
                    return true;
                }
                else if (Tail.Value.Equals(value))
                {
                    this.RemoveLast();
                    return true;
                }
                else
                {
                    DoublyLinkedListNode<T> temp = Head.Next;
                    while (temp != Head)
                    {
                        if (temp.Value.Equals(value))
                        {
                            temp.Previous.Next = temp.Next;
                            temp.Next.Previous = temp.Previous;
                            return true;
                        }
                    }
                    return false;
                }
            }


        }

        public bool Contains(DoublyLinkedListNode<T> value)
        {
            if(value.Owner == this)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Contains(T value)
        {
            DoublyLinkedListNode<T> temp = Head;
            if(temp.Value.Equals(value))
            {
                return true;
            }
            else
            {
                temp = temp.Next;
                while(temp != Head)
                {
                    if(temp.Value.Equals(value))
                    {
                        return true;
                    }
                    temp = temp.Next;
                }
                return false;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        

        public DoublyLinkedListNode<T> Search(T value)
        {
            DoublyLinkedListNode<T> temp = Head;
            if (temp.Value.Equals(value))
            {
                return temp;
            }
            else
            {
                temp = temp.Next;
                while (temp != Head)
                {
                    if (temp.Value.Equals(value))
                    {
                        return temp;
                    }
                }
                return null;
            }
        }


        public void AddBefore(DoublyLinkedListNode<T> node, T value)
        {
            if (!Contains(node)) return;
            if(node == Head)
            {
                AddFirst(value);
            }
            else if(node == Tail)
            {
                AddLast(value);
            }
            else
            {
                DoublyLinkedListNode<T> temp = Head.Next;
                while(temp != node)
                {
                    temp = temp.Next;
                }
                DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(value, this);

                temp.Previous.Next = newNode;
                newNode.Next = temp;
                temp.Previous = newNode;
            }
        }
        
    }
}
