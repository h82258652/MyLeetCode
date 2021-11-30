using FluentAssertions;
using Xunit;

namespace LeetCode268
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 3, 0, 1 }, 2)]
        [InlineData(new[] { 0, 1 }, 2)]
        [InlineData(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
        [InlineData(new[] { 0 }, 1)]
        public void Test(int[] nums, int assertResult)
        {
            var solution = new Solution();
            var result = solution.MissingNumber(nums);
            result.Should().Be(assertResult);
        }
    }
}
