using FluentAssertions;
using Xunit;

namespace LeetCode434
{
    public class TestCases
    {
        [Theory]
        [InlineData("Hello, my name is John", 5)]
        public void Test(string s, int assertResult)
        {
            var solution = new Solution();
            var result = solution.CountSegments(s);
            result.Should().Be(assertResult);
        }
    }
}
