using FluentAssertions;
using Xunit;

namespace LeetCode1037
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.IsBoomerang(new[]
            {
                new[] { 1, 1 },
                new[] { 2, 3 },
                new[] { 3, 2 }
            });
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.IsBoomerang(new[]
            {
                new[] { 1, 1 },
                new[] { 2, 2 },
                new[] { 3, 3 }
            });
            result.Should().BeFalse();
        }
    }
}
