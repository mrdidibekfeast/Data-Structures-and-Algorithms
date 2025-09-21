namespace Insertion_sort
{
    internal class Program
    {
        public static void Bubble(int[] arr, int index)
        {
            for(int i = index;i > 0; i--)
            {
                if (arr[i] < arr[i-1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i-1] = temp;
                }
            }
        }
        public static int[] InsertionSort(int[] arr)
        {
            for(int i = 1; i < arr.Length;i++)
            {
                Bubble(arr, i);
            }

            return arr;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] brandonDao = new int[10];
            for(int i = 0; i < brandonDao.Length;i++)
            {
                brandonDao[i] = rand.Next(1, 11);
                Console.Write(brandonDao[i] + " ");
            }

            brandonDao = InsertionSort(brandonDao);
            Console.WriteLine();
            for(int i = 0; i < brandonDao.Length;i++)
            {
                Console.Write(brandonDao[i] + " ");
            }
        }
    }
}
