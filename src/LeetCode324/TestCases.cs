using FluentAssertions;
using Xunit;

namespace LeetCode324
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new int[] { 1, 5, 1, 1, 6, 4 };
            solution.WiggleSort(nums);
            AssertResult(nums);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new int[] { 1, 3, 2, 2, 3, 1 };
            solution.WiggleSort(nums);
            AssertResult(nums);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var nums = new int[] { 4, 5, 5, 6 };
            solution.WiggleSort(nums);
            AssertResult(nums);
        }

        private void AssertResult(int[] nums)
        {
            var length = nums.Length;
            for (var i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                {
                    if (i - 1 >= 0)
                    {
                        nums[i].Should().BeLessThan(nums[i - 1]);
                    }

                    if (i + 1 < length)
                    {
                        nums[i].Should().BeLessThan(nums[i + 1]);
                    }
                }
                else
                {
                    if (i - 1 >= 0)
                    {
                        nums[i].Should().BeGreaterThan(nums[i - 1]);
                    }

                    if (i + 1 < length)
                    {
                        nums[i].Should().BeGreaterThan(nums[i + 1]);
                    }
                }
            }
        }
    }
}
