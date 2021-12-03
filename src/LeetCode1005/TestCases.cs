using FluentAssertions;
using Xunit;

namespace LeetCode1005
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 4, 2, 3 }, 1, 5)]
        [InlineData(new[] { 3, -1, 0, 2 }, 3, 6)]
        [InlineData(new[] { 2, -3, -1, 5, -4 }, 2, 13)]
        public void Test(int[] nums, int k, int assertResult)
        {
            var solution = new Solution();
            var result = solution.LargestSumAfterKNegations(nums, k);
            result.Should().Be(assertResult);
        }
    }
}
