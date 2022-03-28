using FluentAssertions;
using Xunit;

namespace LeetCode680
{
    public class TestCases
    {
        [Theory]
        [InlineData("aba", true)]
        [InlineData("abca", true)]
        [InlineData("abc", false)]
        public void Test(string s, bool expected)
        {
            var solution = new Solution();
            var result = solution.ValidPalindrome(s);
            result.Should().Be(expected);
        }
    }
}
