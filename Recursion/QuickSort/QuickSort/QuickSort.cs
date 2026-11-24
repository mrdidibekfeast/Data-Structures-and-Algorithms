namespace QuickSort
{
    public class Sorts
    {

        public static void Swap<T>(T[] arr,int index1, int index2) where T : IComparable<T>
        {
            T temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
        public static T[] QuickSortLomuto<T>(T[] array, int startIndex, int endIndex) where T : IComparable<T>
        {
            if(startIndex == endIndex)
            {
                return array;
            }

            int wallIndex = startIndex;
            T pivotValue = array[endIndex];

            for(int i = startIndex; i < endIndex; i++)
            {
                if (array[i].CompareTo(pivotValue) < 0)
                {
                    Swap(array, i, wallIndex);
                    wallIndex++;
                }
            }
            Swap(array, wallIndex, endIndex);

            return array;
        }

        /*
        public static T[] QuickSort<T>(T[] array) where T :IComparable<T>
        {
            if(array.Length <= 1)
            {
                return array;
            }

            T pivotValue = array[0];

            int leftIndicatorIndex = -1;
            int rightIndicatorIndex = array.Length;

            while(leftIndicatorIndex < rightIndicatorIndex)
            {
                leftIndicatorIndex++;
                while (array[leftIndicatorIndex].CompareTo(pivotValue) < 0)
                {
                    leftIndicatorIndex++;
                }
                rightIndicatorIndex--;
                while (array[rightIndicatorIndex].CompareTo(pivotValue) > 0)
                {
                    rightIndicatorIndex--;
                }

                T temp = array[leftIndicatorIndex];
                array[leftIndicatorIndex] = array[rightIndicatorIndex];
                array[rightIndicatorIndex] = temp;
            }

        }
        */

    
    }
}
