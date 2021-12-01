using FluentAssertions;
using Xunit;

namespace LeetCode2011
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { "--X", "X++", "X++" }, 1)]
        [InlineData(new[] { "++X", "++X", "X++" }, 3)]
        [InlineData(new[] { "X++", "++X", "--X", "X--" }, 0)]
        public void Test(string[] operations, int assertResult)
        {
            var solution = new Solution();
            var result = solution.FinalValueAfterOperations(operations);
            result.Should().Be(assertResult);
        }
    }
}
