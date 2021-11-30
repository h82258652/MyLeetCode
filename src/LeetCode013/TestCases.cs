using FluentAssertions;
using Xunit;

namespace LeetCode013
{
    public class TestCases
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void Test(string s, int assertResult)
        {
            var solution = new Solution();
            var result = solution.RomanToInt(s);
            result.Should().Be(assertResult);
        }
    }
}
