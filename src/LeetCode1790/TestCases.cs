using FluentAssertions;
using Xunit;

namespace LeetCode1790
{
    public class TestCases
    {
        [Theory]
        [InlineData("bank", "kanb", true)]
        [InlineData("attack", "defend", false)]
        [InlineData("kelb", "kelb", true)]
        [InlineData("abcd", "dcba", false)]
        public void Test(string s1, string s2, bool expected)
        {
            var solution = new Solution();
            var result = solution.AreAlmostEqual(s1, s2);
            result.Should().Be(expected);
        }
    }
}
