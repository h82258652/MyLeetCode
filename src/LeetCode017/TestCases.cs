using FluentAssertions;
using Xunit;

namespace LeetCode017
{
    public class TestCases
    {
        [Theory]
        [InlineData("23", new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [InlineData("", new string[] { })]
        [InlineData("2", new[] { "a", "b", "c" })]
        public void Test(string digits, string[] expectation)
        {
            var solution = new Solution();
            var result = solution.LetterCombinations(digits);
            result.Should().BeEquivalentTo(expectation);
        }
    }
}
