using FluentAssertions;
using Xunit;

namespace LeetCode455
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 1 }, 1)]
        [InlineData(new[] { 1, 2 }, new[] { 1, 2, 3 }, 2)]
        public void Test(int[] g, int[] s, int assertResult)
        {
            var solution = new Solution();
            var result = solution.FindContentChildren(g, s);
            result.Should().Be(assertResult);
        }
    }
}
