using FluentAssertions;
using Xunit;

namespace LeetCode189
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new[] { 5, 6, 7, 1, 2, 3, 4 })]
        [InlineData(new[] { -1, -100, 3, 99 }, 2, new[] { 3, 99, -1, -100 })]
        public void Test(int[] nums, int k, int[] expected)
        {
            var solution = new Solution();
            solution.Rotate(nums, k);
            nums.Should().Equal(expected);
        }
    }
}
