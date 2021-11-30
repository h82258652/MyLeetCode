using FluentAssertions;
using Xunit;

namespace LeetCode500
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { "Hello", "Alaska", "Dad", "Peace" }, new[] { "Alaska", "Dad" })]
        [InlineData(new[] { "omk" }, new string[] { })]
        [InlineData(new[] { "adsdf", "sfd" }, new[] { "adsdf", "sfd" })]
        public void Test(string[] words, string[] assertResult)
        {
            var solution = new Solution();
            var result = solution.FindWords(words);
            result.Should().Equal(assertResult);
        }
    }
}
