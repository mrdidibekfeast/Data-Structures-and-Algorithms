namespace Merge_Sort
{
    public class Program
    {
        public static T[] MergeSort<T>(T[] items) where T : IComparable<T> 
        {
            if(items.Length == 1)
            {
                return items;
            }

            
            int itemALength;
            int itemBLength;
            if(items.Length % 2 == 0)
            {
                itemALength = items.Length / 2;
                itemBLength = items.Length / 2;
            }
            else
            {
                itemALength = items.Length / 2;
                itemBLength = itemALength + 1;
            }
            T[] itemA = new T[itemALength];
            T[] itemB = new T[itemBLength];

            for (int i = 0; i < itemALength; i++)
            {
                itemA[i] = items[i];
            }
            for(int i = itemALength; i < itemALength + itemBLength;i++)
            {
                itemB[i-itemALength] = items[i];
            }

            itemA = MergeSort(itemA);
            itemB = MergeSort(itemB);

            return Merge(itemA, itemB);

        }
        public static T[] Merge<T>(T[] arrayA, T[] arrayB) where T : IComparable<T>
        {
            T[] combinedArray = new T[arrayA.Length + arrayB.Length];

            int arrayAcount = 0;
            int arrayBcount = 0;
            for (int i = 0; i < combinedArray.Length; i++)
            {
                if(arrayAcount < arrayA.Length && arrayBcount < arrayB.Length)
                {
                    if (arrayA[arrayAcount].CompareTo(arrayB[arrayBcount]) < 0)
                    {
                        combinedArray[i] = arrayA[arrayAcount];
                        arrayAcount++;
                    }
                    else if (arrayB[arrayBcount].CompareTo(arrayA[arrayAcount]) < 0)
                    {
                        combinedArray[i] = arrayB[arrayBcount];
                        arrayBcount++;
                    }
                    else if(arrayA[arrayAcount].CompareTo(arrayB[arrayBcount]) == 0)
                    {
                        combinedArray[i] = arrayA[arrayAcount];
                        arrayAcount++;
                    }
                }
                else if(arrayAcount >= arrayA.Length && arrayBcount < arrayB.Length)
                {
                    while(arrayBcount < arrayB.Length)
                    {
                        combinedArray[i] = arrayB[arrayBcount];
                        arrayBcount++;
                        i++;
                    }
                }
                else if (arrayBcount >= arrayB.Length && arrayAcount < arrayA.Length)
                {
                    while (arrayAcount < arrayA.Length)
                    {
                        combinedArray[i] = arrayA[arrayAcount];
                        arrayAcount++;
                        i++;
                    }
                }

            }

            return combinedArray;
        }
        public static void Main(string[] args)
        {

        }
    }
}

