using FluentAssertions;
using Xunit;

namespace LeetCode605
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 0, 0, 0, 1 }, 1, true)]
        [InlineData(new[] { 1, 0, 0, 0, 1 }, 2, false)]
        [InlineData(new[] { 1, 0, 0, 0, 0, 1 }, 2, false)]
        [InlineData(new[] { 0, 0, 1, 0, 0 }, 1, true)]
        [InlineData(new[] { 0, 0 }, 2, false)]
        public void Test(int[] flowerbed, int n, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.CanPlaceFlowers(flowerbed, n);
            result.Should().Be(assertResult);
        }
    }
}
