using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace MergeSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                int[] nums = new int[100];
                for (int j = 0; j < nums.Length; j++)
                {
                    nums[j] = rand.Next(0, 1001);
                }
                nums = Merge_Sort.Program.MergeSort(nums);
                for (int k = 0; k < nums.Length - 1; k++)
                {
                    Assert.True(nums[k + 1] >= nums[k]);
                }
            }
        }

    }
}
