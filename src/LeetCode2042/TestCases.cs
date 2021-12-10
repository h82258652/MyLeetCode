using FluentAssertions;
using Xunit;

namespace LeetCode2042
{
    public class TestCases
    {
        [Theory]
        [InlineData("1 box has 3 blue 4 red 6 green and 12 yellow marbles", true)]
        [InlineData("hello world 5 x 5", false)]
        [InlineData("sunset is at 7 51 pm overnight lows will be in the low 50 and 60 s", false)]
        [InlineData("4 5 11 26", true)]
        public void Test(string s, bool excepted)
        {
            var solution = new Solution();
            var result = solution.AreNumbersAscending(s);
            result.Should().Be(excepted);
        }
    }
}
