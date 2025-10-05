namespace Stacks
{
    public class LinkedListStack<T>
    {
        public int Count { get; private set; }
        private LinkedList<T> data;

        public LinkedListStack()
        {
            data = new LinkedList<T>();
            Count = 0;
        }
        public void Push(T value)
        {
            data.AddFirst(value);
            Count++;
        }
        public T Pop()
        {
            
           
            LinkedListNode<T> node = data.First;
            if(node != null)
            {
                data.RemoveFirst();
                Count--;
                return node.Value;
            }
            else
            {
                throw new InvalidOperationException("Empty Stack");
            }
           
        }
        public T Peek()
        {
            LinkedListNode<T> node = data.First;
            if (node != null)
            {
                return node.Value;
            }
            else
            {
                throw new InvalidOperationException("Empty Stack");
            }
        }

    
        public void Clear()
        {
            data.Clear();
            Count = 0;
        }
        public bool IsEmpty()
        {
            if(Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
