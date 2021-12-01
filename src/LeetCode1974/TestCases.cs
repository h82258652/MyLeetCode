using FluentAssertions;
using Xunit;

namespace LeetCode1974
{
    public class TestCases
    {
        [Theory]
        [InlineData("abc", 5)]
        [InlineData("bza", 7)]
        [InlineData("zjpc", 34)]
        public void Test(string word, int assertResult)
        {
            var solution = new Solution();
            var result = solution.MinTimeToType(word);
            result.Should().Be(assertResult);
        }
    }
}
