using FluentAssertions;
using Xunit;

namespace LeetCode2068
{
    public class TestCases
    {
        [Theory]
        [InlineData("aaaa", "bccb", false)]
        [InlineData("abcdeef", "abaaacc", true)]
        [InlineData("cccddabba", "babababab", true)]
        public void Test(string word1, string word2, bool expected)
        {
            var solution = new Solution();
            var result = solution.CheckAlmostEquivalent(word1, word2);
            result.Should().Be(expected);
        }
    }
}
