using FluentAssertions;
using Xunit;

namespace LeetCode389
{
    public class TestCases
    {
        [Theory]
        [InlineData("abcd", "abcde", 'e')]
        [InlineData("", "y", 'y')]
        [InlineData("a", "aa", 'a')]
        [InlineData("ae", "aea", 'a')]
        public void Test(string s, string t, char assertResult)
        {
            var solution = new Solution();
            var result = solution.FindTheDifference(s, t);
            result.Should().Be(assertResult);
        }
    }
}
