namespace Bubble_Sort
{
    internal class Program
    {

        public static int[] bubbleSort(int[] arr)
        {
            int numsorted = 0;
            bool sort = true;
            while(sort)
            {
                sort = false;
                for (int i = 0; i < arr.Length - 1 - numsorted; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        sort = true;
                    }
                }
                numsorted++;
            }
           
            return arr;
        }
        static void Main(string[] args)
        {
            int[] brandonDao = new int[10];
            Random rand = new Random();

            for(int i = 0; i < brandonDao.Length;i++)
            {
                brandonDao[i] = rand.Next(1, 11);
                Console.Write(brandonDao[i] + " ");
            }

            int[] newArr = bubbleSort(brandonDao);
            Console.WriteLine();

            for(int i = 0; i < brandonDao.Length;i++)
            {
                Console.Write(brandonDao[i] + " ");
            }
        }
    }
}
