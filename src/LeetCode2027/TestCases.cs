using FluentAssertions;
using Xunit;

namespace LeetCode2027
{
    public class TestCases
    {
        [Theory]
        [InlineData("XXX", 1)]
        [InlineData("XXOX", 2)]
        [InlineData("OOOO", 0)]
        public void Test(string s, int excepted)
        {
            var solution = new Solution();
            var result = solution.MinimumMoves(s);
            result.Should().Be(excepted);
        }
    }
}
