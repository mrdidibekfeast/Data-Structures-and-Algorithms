using Queues;
namespace QueuesUnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2,3,4,5)]
        public void enqueueTest(params int[] array)
        {
            Queue<int> queue = new Queue<int>();
            LinkedListQueue<int> llqueue = new LinkedListQueue<int>();
            for(int i = 0; i < array.Length;i++)
            {
                queue.Enqueue(array[i]);
                llqueue.Enqueue(array[i]);
            }

            Assert.Equal(llqueue.Peek(), queue.Peek());
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5)]
        public void dequeueueTest(params int[] array)
        {
            Queue<int> queue = new Queue<int>();
            LinkedListQueue<int> llqueue = new LinkedListQueue<int>();
            for (int i = 0; i < array.Length; i++)
            {
                queue.Enqueue(array[i]);
                llqueue.Enqueue(array[i]);
            }
            queue.Dequeue();
            llqueue.Dequeue();

            Assert.Equal(llqueue.Peek(), queue.Peek());
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5)]
        public void clearTest(params int[] array)
        {
            Queue<int> queue = new Queue<int>();
            LinkedListQueue<int> llqueue = new LinkedListQueue<int>();
            for (int i = 0; i < array.Length; i++)
            {
                queue.Enqueue(array[i]);
                llqueue.Enqueue(array[i]);
            }
            queue.Clear();
            llqueue.Clear();

            Assert.Equal(llqueue.IsEmpty(), queue.Count == 0);
            Assert.Equal(queue.Count, llqueue.Count);
        }
    }
}