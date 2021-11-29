using FluentAssertions;
using Xunit;

namespace LeetCode136
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 2, 2, 1 }, 1)]
        [InlineData(new[] { 4, 1, 2, 1, 2 }, 4)]
        public void Test(int[] nums, int assertResult)
        {
            var solution = new Solution();
            var result = solution.SingleNumber(nums);
            result.Should().Be(assertResult);
        }
    }
}
