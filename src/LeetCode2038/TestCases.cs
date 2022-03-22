using FluentAssertions;
using Xunit;

namespace LeetCode2038
{
    public class TestCases
    {
        [Theory]
        [InlineData("AAABABB", true)]
        [InlineData("AA", false)]
        [InlineData("ABBBBBBBAAA", false)]
        public void Test(string colors, bool expected)
        {
            var solution = new Solution();
            var result = solution.WinnerOfGame(colors);
            result.Should().Be(expected);
        }
    }
}
