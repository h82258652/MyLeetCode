using FluentAssertions;
using Xunit;

namespace LeetCode290
{
    public class TestCases
    {
        [Theory]
        [InlineData("abba", "dog cat cat dog", true)]
        [InlineData("abba", "dog cat cat fish", false)]
        [InlineData("aaaa", "dog cat cat dog", false)]
        [InlineData("abba", "dog dog dog dog", false)]
        [InlineData("aaa", "aa aa aa aa", false)]
        public void Test(string pattern, string s, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.WordPattern(pattern, s);
            result.Should().Be(assertResult);
        }
    }
}
