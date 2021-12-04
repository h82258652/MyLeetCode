using FluentAssertions;
using Xunit;

namespace LeetCode746
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 10, 15, 20 }, 15)]
        [InlineData(new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, 6)]
        public void Test(int[] cost, int assertResult)
        {
            var solution = new Solution();
            var result = solution.MinCostClimbingStairs(cost);
            result.Should().Be(assertResult);
        }
    }
}
