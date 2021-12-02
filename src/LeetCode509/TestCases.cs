using FluentAssertions;
using Xunit;

namespace LeetCode509
{
    public class TestCases
    {
        [Theory]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(0, 0)]
        public void Test(int n, int assertResult)
        {
            var solution = new Solution();
            var result = solution.Fib(n);
            result.Should().Be(assertResult);
        }
    }
}
