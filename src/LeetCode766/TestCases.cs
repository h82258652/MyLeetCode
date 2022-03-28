using FluentAssertions;
using Xunit;

namespace LeetCode766
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.IsToeplitzMatrix(new[]
            {
                new[] { 1, 2, 3, 4 },
                new[] { 5, 1, 2, 3 },
                new[] { 9, 5, 1, 2 }
            });
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.IsToeplitzMatrix(new[]
            {
                new[] { 1, 2 },
                new[] { 2, 2 }
            });
            result.Should().BeFalse();
        }
    }
}
