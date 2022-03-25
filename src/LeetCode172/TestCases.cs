using FluentAssertions;
using Xunit;

namespace LeetCode172
{
    public class TestCases
    {
        [Theory]
        [InlineData(3, 0)]
        [InlineData(5, 1)]
        [InlineData(0, 0)]
        public void Test(int n, int expected)
        {
            var solution = new Solution();
            var result = solution.TrailingZeroes(n);
            result.Should().Be(expected);
        }
    }
}
