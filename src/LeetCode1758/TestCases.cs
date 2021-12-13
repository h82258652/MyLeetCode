using FluentAssertions;
using Xunit;

namespace LeetCode1758
{
    public class TestCases
    {
        [Theory]
        [InlineData("0100", 1)]
        [InlineData("10", 0)]
        [InlineData("1111", 2)]
        [InlineData("10010100", 3)]
        public void Test(string s, int expected)
        {
            var solution = new Solution();
            var result = solution.MinOperations(s);
            result.Should().Be(expected);
        }
    }
}
