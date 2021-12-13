using FluentAssertions;
using Xunit;

namespace LeetCode1880
{
    public class TestCases
    {
        [Theory]
        [InlineData("acb", "cba", "cdb", true)]
        [InlineData("aaa", "a", "aab", false)]
        [InlineData("aaa", "a", "aaaa", true)]
        public void Test(string firstWord, string secondWord, string targetWord, bool expected)
        {
            var solution = new Solution();
            var result = solution.IsSumEqual(firstWord, secondWord, targetWord);
            result.Should().Be(expected);
        }
    }
}
