using FluentAssertions;
using Xunit;

namespace LeetCode1020
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.NumEnclaves(new[]
            {
                new[] { 0, 0, 0, 0 },
                new[] { 1, 0, 1, 0 },
                new[] { 0, 1, 1, 0 },
                new[] { 0, 0, 0, 0 }
            });
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.NumEnclaves(new[]
            {
                new[] { 0, 1, 1, 0 },
                new[] { 0, 0, 1, 0 },
                new[] { 0, 0, 1, 0 },
                new[] { 0, 0, 0, 0 }
            });
            result.Should().Be(0);
        }
    }
}
