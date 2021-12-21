using FluentAssertions;
using Xunit;

namespace LeetCode821
{
    public class TestCases
    {
        [Theory]
        [InlineData("loveleetcode", 'e', new[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 })]
        [InlineData("aaab", 'b', new[] { 3, 2, 1, 0 })]
        public void Test(string s, char c, int[] expected)
        {
            Solution solution = new Solution();
            var result = solution.ShortestToChar(s, c);
            result.Should().Equal(expected);
        }
    }
}
