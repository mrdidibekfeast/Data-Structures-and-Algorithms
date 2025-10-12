using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class LinkedListQueue<T>
    {
        public int Count { get; private set; } // The amount of items in the Queue
        private LinkedList<T> data; // Backing for the Queue

        public LinkedListQueue()
        {
            Count = 0;
            data = new LinkedList<T>();
        }// Construct the Queue

        public void Enqueue(T value)
        {
            data.AddLast(value);
            Count++;
        }
        public T Dequeue()
        {
            T returnValue = data.First();
            data.RemoveFirst();
            Count--;
            return returnValue;
        }
        public T Peek()
        {
            return data.First();
        }

        // Optional Functions
        public bool IsEmpty()
        {
            if(Count == 0)
            {
                return true;
            }
            return false;
        }
        public void Clear()
        {
            Count = 0;
            data.Clear();
        }
    }
}
