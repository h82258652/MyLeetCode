using FluentAssertions;
using Xunit;

namespace LeetCode058
{
    public class TestCases
    {
        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        [InlineData("day", 3)]
        public void Test(string s, int assertResult)
        {
            var solution = new Solution();
            var result = solution.LengthOfLastWord(s);
            result.Should().Be(assertResult);
        }
    }
}
