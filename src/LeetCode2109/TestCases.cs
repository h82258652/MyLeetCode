using FluentAssertions;
using Xunit;

namespace LeetCode2109
{
    public class TestCases
    {
        [Theory]
        [InlineData("LeetcodeHelpsMeLearn", new int[] { 8, 13, 15 }, "Leetcode Helps Me Learn")]
        [InlineData("icodeinpython", new int[] { 1, 5, 7, 9 }, "i code in py thon")]
        [InlineData("spacing", new int[] { 0, 1, 2, 3, 4, 5, 6 }, " s p a c i n g")]
        public void Test(string s, int[] spaces, string expected)
        {
            var solution = new Solution();
            var result = solution.AddSpaces(s, spaces);
            result.Should().Be(expected);
        }
    }
}
