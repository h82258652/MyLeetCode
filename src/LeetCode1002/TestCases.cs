using FluentAssertions;
using Xunit;

namespace LeetCode1002
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { "bella", "label", "roller" }, new[] { "e", "l", "l" })]
        [InlineData(new[] { "cool", "lock", "cook" }, new[] { "c", "o" })]
        [InlineData(new[] { "dadaabaa", "bdaaabcc", "abccddbb", "bbaacdba", "ababbbab", "ccddbbba", "bbdabbda", "bdabaacb" }, new[] { "a", "b" })]
        public void Test(string[] words, string[] assertResult)
        {
            var solution = new Solution();
            var result = solution.CommonChars(words);
            result.Should().BeEquivalentTo(assertResult);
        }
    }
}
