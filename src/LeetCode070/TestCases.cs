using FluentAssertions;
using Xunit;

namespace LeetCode070
{
    public class TestCases
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void Test(int n, int assertResult)
        {
            var solution = new Solution();
            var result = solution.ClimbStairs(n);
            result.Should().Be(assertResult);
        }
    }
}
