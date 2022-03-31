using FluentAssertions;
using Xunit;

namespace LeetCode2133
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var matrix = new[]
            {
                new[] { 1, 2, 3 },
                new[] { 3, 1, 2 },
                new[] { 2, 3, 1 }
            };
            var result = solution.CheckValid(matrix);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var matrix = new[]
            {
                new[] { 1, 1, 1 },
                new[] { 1, 2, 3 },
                new[] { 1, 2, 3 }
            };
            var result = solution.CheckValid(matrix);
            result.Should().BeFalse();
        }
    }
}
