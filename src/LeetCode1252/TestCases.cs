using FluentAssertions;
using Xunit;

namespace LeetCode1252
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.OddCells(2, 3, new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 1 }
            });
            result.Should().Be(6);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.OddCells(2, 2, new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 0, 0 }
            });
            result.Should().Be(0);
        }
    }
}
