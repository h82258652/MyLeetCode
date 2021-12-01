using FluentAssertions;
using Xunit;

namespace LeetCode1446
{
    public class TestCases
    {
        [Theory]
        [InlineData("leetcode", 2)]
        [InlineData("abbcccddddeeeeedcba", 5)]
        [InlineData("triplepillooooow", 5)]
        [InlineData("hooraaaaaaaaaaay", 11)]
        [InlineData("tourist", 1)]
        public void Test(string s, int assertResult)
        {
            var solution = new Solution();
            var result = solution.MaxPower(s);
            result.Should().Be(assertResult);
        }
    }
}
