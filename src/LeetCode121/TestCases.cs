using FluentAssertions;
using Xunit;

namespace LeetCode121
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
        public void Test(int[] prices, int excepted)
        {
            var solution = new Solution();
            var result = solution.MaxProfit(prices);
            result.Should().Be(excepted);
        }
    }
}
