using FluentAssertions;
using Xunit;

namespace LeetCode1768
{
    public class TestCases
    {
        [Theory]
        [InlineData("abc", "pqr", "apbqcr")]
        [InlineData("ab", "pqrs", "apbqrs")]
        [InlineData("abcd", "pq", "apbqcd")]
        public void Test(string word1, string word2, string expected)
        {
            var solution = new Solution();
            var result = solution.MergeAlternately(word1, word2);
            result.Should().Be(expected);
        }
    }
}
