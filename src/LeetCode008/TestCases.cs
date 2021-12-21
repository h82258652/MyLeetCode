using FluentAssertions;
using Xunit;

namespace LeetCode008
{
    public class TestCases
    {
        [Theory]
        [InlineData("42", 42)]
        [InlineData("   -42", -42)]
        [InlineData("4193 with words", 4193)]
        [InlineData("words and 987", 0)]
        [InlineData("-91283472332", -2147483648)]
        [InlineData("+1", 1)]
        [InlineData("00000-42a1234", 0)]
        public void Test(string s, int expected)
        {
            var solution = new Solution();
            var result = solution.MyAtoi(s);
            result.Should().Be(expected);
        }
    }
}
