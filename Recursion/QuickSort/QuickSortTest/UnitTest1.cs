using QuickSort;
namespace QuickSortTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] array = {7,4,3,6,2,1,5};
            int[] newArray = Sorts.QuickSortLomuto<int>(array,0,array.Length-1);
        }
    }
}
