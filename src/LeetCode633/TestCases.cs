using FluentAssertions;
using Xunit;

namespace LeetCode633
{
    public class TestCases
    {
        [Theory]
        [InlineData(5, true)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(2, true)]
        [InlineData(1, true)]
        [InlineData(2147483600, true)]
        public void Test(int c, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.JudgeSquareSum(c);
            result.Should().Be(assertResult);
        }
    }
}
