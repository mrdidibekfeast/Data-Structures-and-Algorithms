using Merge_Sort;
namespace mergeSortTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Random rand = new Random();

            for(int i = 0; i < 100; i++)
            {
                int[] nums = new int[100];
                for(int j = 0; j < nums.Length; j++)
                {
                    nums[j] = rand.Next(0,1001);
                }
                nums = Program.MergeSort(nums);
                for(int k = 0; k < nums.Length - 1; k++)
                {
                    Assert.IsTrue(nums[k + 1] >= nums[k]);
                }
            }
        }
    }
}
