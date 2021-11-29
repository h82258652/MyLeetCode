using FluentAssertions;
using Xunit;

namespace LeetCode007
{
    public class TestCases
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(0, 0)]
        [InlineData(1534236469, 0)]
        public void Test(int x, int assertResult)
        {
            var solution = new Solution();
            var result = solution.Reverse(x);
            result.Should().Be(assertResult);
        }
    }
}
