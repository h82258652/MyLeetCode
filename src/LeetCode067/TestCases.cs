using FluentAssertions;
using Xunit;

namespace LeetCode067
{
    public class TestCases
    {
        [Theory]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        public void Test(string a, string b, string assertResult)
        {
            var solution = new Solution();
            var result = solution.AddBinary(a, b);
            result.Should().Be(assertResult);
        }
    }
}
