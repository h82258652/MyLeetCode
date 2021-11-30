using FluentAssertions;
using Xunit;

namespace LeetCode387
{
    public class TestCases
    {
        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        public void Test(string s, int assertResult)
        {
            var solution = new Solution();
            var result = solution.FirstUniqChar(s);
            result.Should().Be(assertResult);
        }
    }
}
