﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class ArrayQueue<T>
    {
        public int Count { get; private set; } // The amount of items in the Queue
        private T[] data; // Backing for the Queue
        private int head; // The point to remove at
        private int tail; // The point to add at

        public ArrayQueue()
        {
            data = new T[10];
            Count = 0;
            head = 0;
            tail = 0;
        }// Construct the Queue

        public void Enqueue(T value)
        {
            if(Count == data.Length)
            {
                Resize(data.Length * 2);
                data[tail + 1] = value;
            }
            Count++;
            //finish
        }
        public T Dequeue() { ... } // Remove and get the item at the front of the Queue
        public T Peek()
        {
            return data[head];
        }// Get the item at the front of the Queue

        private void Resize(int size)
        {
            T[] newArr = new T[size];
            int index = 0;
            int ptr = head;
            while(ptr != tail)
            {
                if(ptr > data.Length)
                {
                    ptr = 0;
                }
                newArr[index] = data[ptr];
                index++;
                ptr++;
            }

            data = newArr;
            head = 0;
            tail = index - 1;
        }// Resize and re-index the data 

        // Optional Functions
        public bool IsEmpty()
        {
            if (Count == 0)
            {
                return true;
            }
            return false;
        }// Returns if the Queue is empty
        public void Clear()
        {
            Count = 0;
            head = 0;
            tail = 0;
        }// Deletes all data in the Queue
    }
}
