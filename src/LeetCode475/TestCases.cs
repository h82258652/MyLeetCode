using FluentAssertions;
using Xunit;

namespace LeetCode475
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 2 }, 1)]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 4 }, 1)]
        [InlineData(new[] { 1, 5 }, new[] { 2 }, 3)]
        [InlineData(new[] { 282475249, 622650073, 984943658, 144108930, 470211272, 101027544, 457850878, 458777923 }, new[] { 823564440, 115438165, 784484492, 74243042, 114807987, 137522503, 441282327, 16531729, 823378840, 143542612 }, 161834419)]
        public void Test(int[] houses, int[] heaters, int expected)
        {
            var solution = new Solution();
            var result = solution.FindRadius(houses, heaters);
            result.Should().Be(expected);
        }
    }
}
