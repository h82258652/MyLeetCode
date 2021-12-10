using FluentAssertions;
using Xunit;

namespace LeetCode796
{
    public class TestCases
    {
        [Theory]
        [InlineData("abcde", "cdeab", true)]
        [InlineData("abcde", "abced", false)]
        public void Test(string s, string goal, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.RotateString(s, goal);
            result.Should().Be(assertResult);
        }
    }
}
