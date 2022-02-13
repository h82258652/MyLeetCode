using FluentAssertions;
using Xunit;

namespace LeetCode1189
{
    public class TestCases
    {
        [Theory]
        [InlineData("nlaebolko", 1)]
        [InlineData("loonbalxballpoon", 2)]
        [InlineData("leetcode", 0)]
        public void Test(string text, int expected)
        {
            var solution = new Solution();
            var result = solution.MaxNumberOfBalloons(text);
            result.Should().Be(expected);
        }
    }
}
