using FluentAssertions;
using Xunit;

namespace LeetCode498
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var mat = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            var result = solution.FindDiagonalOrder(mat);
            var expected = new int[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 };
            result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var mat = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
            var result = solution.FindDiagonalOrder(mat);
            var expected = new int[] { 1, 2, 3, 4 };
            result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
