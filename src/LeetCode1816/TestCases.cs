using FluentAssertions;
using Xunit;

namespace LeetCode1816
{
    public class TestCases
    {
        [Theory]
        [InlineData("Hello how are you Contestant", 4, "Hello how are you")]
        [InlineData("What is the solution to this problem", 4, "What is the solution")]
        [InlineData("chopper is not a tanuki", 5, "chopper is not a tanuki")]
        public void Test(string s, int k, string assertResult)
        {
            var solution = new Solution();
            var result = solution.TruncateSentence(s, k);
            result.Should().Be(assertResult);
        }
    }
}
