using FluentAssertions;
using Xunit;

namespace LeetCode883
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var grid = new[]
            {
                new[] { 1, 2 },
                new[] { 3, 4 }
            };
            var result = solution.ProjectionArea(grid);
            result.Should().Be(17);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var grid = new[]
            {
                new[] { 2 }
            };
            var result = solution.ProjectionArea(grid);
            result.Should().Be(17);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var grid = new[]
            {
                new[] { 1, 0 },
                new[] { 0, 2 }
            };
            var result = solution.ProjectionArea(grid);
            result.Should().Be(17);
        }
    }
}
