using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class ArrayStack<T>
    {
        public int Count { get; private set; }
        private T[] data;

        public ArrayStack(int capacity = 10)
        {
            data = new T[capacity];
        }
        public void Push(T value)
        {
            if(Count != data.Length)
            {
                data[Count] = value;
                Count++;
            }
            else
            {
                Resize(data.Length * 2);
                data[Count] = value;
                Count++;
            }
        }
        public T Pop()
        {
            if(Count  == 0)
            {
                throw new Exception("Empty Stack");
            }
            else
            {
                T value = data[Count - 1];
                Count--;
                return value;
            }
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new Exception("Empty Stack");
            }
            else
            {
                return data[Count - 1];
            }
        }
        private void Resize(int size)
        {
            T[] newArr = new T[size];
            for(int i = 0; i < data.Length;i++)
            {
                newArr[i] = data[i];
            }
            data = newArr;
        }

        public void Clear()
        {
            Count = 0;
        }
        public bool IsEmpty()
        {
            if (Count == 0) return true;
            return false;
        }
    }
}
