using FluentAssertions;
using Xunit;

namespace LeetCode2006
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 2, 1 }, 1, 4)]
        [InlineData(new[] { 1, 3 }, 3, 0)]
        [InlineData(new[] { 3, 2, 1, 5, 4 }, 2, 3)]
        public void Test(int[] nums, int k, int expected)
        {
            var solution = new Solution();
            var result = solution.CountKDifference(nums, k);
            result.Should().Be(expected);
        }
    }
}
