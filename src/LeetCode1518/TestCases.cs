using FluentAssertions;
using Xunit;

namespace LeetCode1518
{
    public class TestCases
    {
        [Theory]
        [InlineData(9, 3, 13)]
        [InlineData(15, 4, 19)]
        [InlineData(5, 5, 6)]
        [InlineData(2, 3, 2)]
        public void Test(int numBottles, int numExchange, int expected)
        {
            var solution = new Solution();
            var result = solution.NumWaterBottles(numBottles, numExchange);
            result.Should().Be(expected);
        }
    }
}
