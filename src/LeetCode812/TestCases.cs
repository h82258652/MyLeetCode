using FluentAssertions;
using Xunit;

namespace LeetCode812
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var points = new int[][] { new int[] { 0, 0 }, new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, 2 }, new int[] { 2, 0 } };
            var result = solution.LargestTriangleArea(points);
            result.Should().Be(2);
        }
    }
}
