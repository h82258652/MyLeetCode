using FluentAssertions;
using Xunit;

namespace LeetCode1078
{
    public class TestCases
    {
        [Theory]
        [InlineData("alice is a good girl she is a good student", "a", "good", new[] { "girl", "student" })]
        [InlineData("we will we will rock you", "we", "will", new[] { "we", "rock" })]
        public void Test(string text, string first, string second, string[] expected)
        {
            var solution = new Solution();
            var result = solution.FindOcurrences(text, first, second);
            result.Should().Equal(expected);
        }
    }
}
