using FluentAssertions;
using Xunit;

namespace LeetCode2185
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { "pay", "attention", "practice", "attend" }, "at", 2)]
        [InlineData(new[] { "leetcode", "win", "loops", "success" }, "code", 0)]
        public void Test(string[] words, string pref, int expected)
        {
            var solution = new Solution();
            var result = solution.PrefixCount(words, pref);
            result.Should().Be(expected);
        }
    }
}
