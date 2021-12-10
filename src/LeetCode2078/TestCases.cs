using FluentAssertions;
using Xunit;

namespace LeetCode2078
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 1, 1, 6, 1, 1, 1 }, 3)]
        [InlineData(new[] { 1, 8, 3, 8, 3 }, 4)]
        [InlineData(new[] { 0, 1 }, 1)]
        public void Test(int[] colors, int expected)
        {
            var solution = new Solution();
            var result = solution.MaxDistance(colors);
            result.Should().Be(expected);
        }
    }
}
