using FluentAssertions;
using Xunit;

namespace LeetCode322
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 5 }, 11, 3)]
        [InlineData(new[] { 2 }, 3, -1)]
        [InlineData(new[] { 1 }, 0, 0)]
        [InlineData(new[] { 1 }, 1, 1)]
        [InlineData(new[] { 1 }, 2, 2)]
        [InlineData(new[] { 1, 2, 5 }, 100, 20)]
        public void Test(int[] coins, int amount, int assertResult)
        {
            var solution = new Solution();
            var result = solution.CoinChange(coins, amount);
            result.Should().Be(assertResult);
        }
    }
}
