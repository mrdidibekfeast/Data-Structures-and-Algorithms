namespace Generics
{
    internal class Program
    {
        public class MarcusList<T> where T : IComparable
        {
            public T[] arr;
            public int count;

            public MarcusList()
            {
                arr = new T[2];
            }
            public void Add(T item)
            {
                if (count == arr.Length)
                {
                    T[] newArr = new T[arr.Length * 2];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        newArr[i] = arr[i];
                    }
                    arr = newArr;
                }

                arr[count] = item;
                count++;

            }

            public bool Contains(T item)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].CompareTo(item) == 0)
                    {
                        return true;
                    }
                }

                return false;
            }

            public int IndexFinder(T item)
            {

                for (int i = 0; i < count; i++)
                {
                    if (arr[i].CompareTo(item) == 0)
                    {
                        return i;
                    }
                }

                return -1;
            }

            public void Remove(T item)
            {
                if (IndexFinder(item) != -1)
                {
                    T[] temp = new T[count - 1];

                    int k = 0;
                    for (int i = 0; i < count; i++)
                    {
                        if (arr[i].CompareTo(item) != 0)
                        {
                            temp[k] = arr[i];
                            k++;
                        }
                    }
                    arr = temp;

                    count--;
                }
            }

            public void Print()
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            MarcusList<int> list = new MarcusList<int>();

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            list.Print();

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            list.Print();

            Console.WriteLine();
            Console.WriteLine(list.Contains(1));

            list.Remove(4);
            list.Print();

        }
    }
}
