using FluentAssertions;
using Xunit;

namespace LeetCode1984
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 90 }, 1, 0)]
        [InlineData(new[] { 9, 4, 1, 7 }, 2, 2)]
        public void Test(int[] nums, int k, int expected)
        {
            var solution = new Solution();
            var result = solution.MinimumDifference(nums, k);
            result.Should().Be(expected);
        }
    }
}
