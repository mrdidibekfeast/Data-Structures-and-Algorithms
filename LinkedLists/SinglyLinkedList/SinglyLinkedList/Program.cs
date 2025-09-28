namespace SinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            LinkedList<int> list = new LinkedList<int>(5);

            Node<int> node = new Node<int>(5,list);
            list.AddFirst(1);
            list.AddBefore(node,67);
            
        }
    }
}
