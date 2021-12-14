using FluentAssertions;
using Xunit;

namespace LeetCode003
{
    public class TestCases
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        [InlineData("dvdf", 3)]
        public void Test(string s, int excepted)
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring(s);
            result.Should().Be(excepted);
        }
    }
}
