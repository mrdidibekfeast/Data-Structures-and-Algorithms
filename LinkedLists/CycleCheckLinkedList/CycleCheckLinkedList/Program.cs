namespace CycleCheckLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> first = new Node<int>(1);
            first.Next = new Node<int>(1);
            first.Next.Next = new Node<int>(1);
            first.Next.Next.Next = new Node<int>(1);
            first.Next.Next.Next.Next = new Node<int>(1);
            first.Next.Next.Next.Next.Next = new Node<int>(1);
            first.Next.Next.Next.Next.Next.Next = new Node<int>(1);
            first.Next.Next.Next.Next.Next.Next.Next = new Node<int>(1);
            first.Next.Next.Next.Next.Next.Next.Next.Next = first;


            Console.WriteLine(LinkedList<int>.CycleCheck(first));

            Node<int> second = new Node<int>(1);
            second.Next = new Node<int>(1);
            second.Next.Next = new Node<int>(1);
            second.Next.Next.Next = new Node<int>(1);
            second.Next.Next.Next.Next = new Node<int>(1);
            second.Next.Next.Next.Next.Next = new Node<int>(1);
            second.Next.Next.Next.Next.Next.Next = new Node<int>(1);
            second.Next.Next.Next.Next.Next.Next.Next = new Node<int>(1);
            second.Next.Next.Next.Next.Next.Next.Next.Next = null;


            Console.WriteLine(LinkedList<int>.CycleCheck(second));
        }
    }
}
