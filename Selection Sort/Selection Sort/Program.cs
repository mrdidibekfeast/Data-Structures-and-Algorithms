namespace Selection_Sort
{
    internal class Program
    {
        public static int[] selectionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length;i++)
            {
                int min = arr[i];
                int minIndex = i;
                for(int k = i + 1; k < arr.Length;k++)
                {
                    if (arr[k] < arr[minIndex])
                    {
                        minIndex = k;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            return arr;
        }
        static void Main(string[] args)
        {
            int[] brandonDao = new int[10];
            Random rand = new Random();

            for (int i = 0; i < brandonDao.Length; i++)
            {
                brandonDao[i] = rand.Next(1, 11);
                Console.Write(brandonDao[i] + " ");
            }

            int[] newArr = selectionSort(brandonDao);
            Console.WriteLine();

            for(int i = 0; i < brandonDao.Length;i++)
            {
                Console.Write(brandonDao[i] + " ");
            }
        }
    }
}
