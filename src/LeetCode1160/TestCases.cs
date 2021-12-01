using FluentAssertions;
using Xunit;

namespace LeetCode1160
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { "cat", "bt", "hat", "tree" }, "atach", 6)]
        [InlineData(new[] { "hello", "world", "leetcode" }, "welldonehoneyr", 10)]
        public void Test(string[] words, string chars, int assertResult)
        {
            var solution = new Solution();
            var result = solution.CountCharacters(words, chars);
            result.Should().Be(assertResult);
        }
    }
}
