using FluentAssertions;
using Xunit;

namespace LeetCode1706
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var grid = new[]
            {
                new[]{ 1, 1, 1,-1,-1},
                new[]{ 1, 1, 1,-1,-1},
                new[]{-1,-1,-1, 1, 1},
                new[]{ 1, 1, 1, 1,-1},
                new[]{-1,-1,-1,-1,-1}
            };
            var result = solution.FindBall(grid);
            result.Should().Equal(1, -1, -1, -1, -1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var grid = new[]
            {
                new[]{-1}
            };
            var result = solution.FindBall(grid);
            result.Should().Equal(-1);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var grid = new[]
            {
                new[]{ 1, 1, 1, 1, 1, 1},
                new[]{-1,-1,-1,-1,-1,-1},
                new[]{ 1, 1, 1, 1, 1, 1},
                new[]{-1,-1,-1,-1,-1,-1}
            };
            var result = solution.FindBall(grid);
            result.Should().Equal(0, 1, 2, 3, 4, -1);
        }
    }
}
