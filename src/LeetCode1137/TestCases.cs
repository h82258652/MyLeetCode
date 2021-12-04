using FluentAssertions;
using Xunit;

namespace LeetCode1137
{
    public class TestCases
    {
        [Theory]
        [InlineData(4, 4)]
        [InlineData(25, 1389537)]
        public void Test(int n, int assertResult)
        {
            var solution = new Solution();
            var result = solution.Tribonacci(n);
            result.Should().Be(assertResult);
        }
    }
}
