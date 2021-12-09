using FluentAssertions;
using Xunit;

namespace LeetCode150
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { "2", "1", "+", "3", "*" }, 9)]
        [InlineData(new[] { "4", "13", "5", "/", "+" }, 6)]
        [InlineData(new[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }, 22)]
        public void Test(string[] tokens, int assertResult)
        {
            var solution = new Solution();
            var result = solution.EvalRPN(tokens);
            result.Should().Be(assertResult);
        }
    }
}
