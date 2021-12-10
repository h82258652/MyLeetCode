using FluentAssertions;
using Xunit;

namespace LeetCode2085
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { "leetcode", "is", "amazing", "as", "is" }, new[] { "amazing", "leetcode", "is" }, 2)]
        [InlineData(new[] { "b", "bb", "bbb" }, new[] { "a", "aa", "aaa" }, 0)]
        [InlineData(new[] { "a", "ab" }, new[] { "a", "a", "a", "ab" }, 1)]
        public void Test(string[] words1, string[] words2, int expected)
        {
            var solution = new Solution();
            var result = solution.CountWords(words1, words2);
            result.Should().Be(expected);
        }
    }
}
