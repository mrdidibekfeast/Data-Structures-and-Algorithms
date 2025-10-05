using System.IO.Pipes;

namespace StackTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }
        [Theory]
        [InlineData(1,2,3,4,5)]
        [InlineData()]
        public void AddTest(params int[] arr)
        {
            Stack<int> stack = new Stack<int>();
            Stacks.LinkedListStack<int> stackll = new Stacks.LinkedListStack<int>();
            Stacks.ArrayStack<int> stacka = new Stacks.ArrayStack<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
                stackll.Push(arr[i]);
                stacka.Push(arr[i]);
                Assert.Equal(stack.Peek(), stackll.Peek());
                Assert.Equal(stack.Peek(), stacka.Peek());
            }
        }

        [Theory]
        [InlineData(1,2,3,4)]

        public void popTest(params int[] arr)
        {
            Stack<int> stack = new Stack<int>();
            Stacks.LinkedListStack<int> stackll = new Stacks.LinkedListStack<int>();
            Stacks.ArrayStack<int> stacka = new Stacks.ArrayStack<int>();
            for (int i = 0; i < arr.Length; i++)
            {
               stack.Push(arr[i]);
               stackll.Push(arr[i]);
               stacka.Push(arr[i]);
            }
          
            for (int i = 0; i < arr.Length; i++)
            {
               int value = stack.Pop();
               Assert.Equal(value, stackll.Pop());
               Assert.Equal(value, stacka.Pop());
            }

        }

        [Fact]
        public void test4()
        {
            Stack<int> stack = new Stack<int>();
            Stacks.LinkedListStack<int> stackll = new Stacks.LinkedListStack<int>();
            stackll.Push(1);
            stackll.Clear();
            Stacks.ArrayStack<int> stacka = new Stacks.ArrayStack<int>();
            stacka.Push(1);
            stacka.Clear();
            Assert.Equal(stack.Count,stackll.Count);
            Assert.Equal(stack.Count, stacka.Count);
        }

    }
}