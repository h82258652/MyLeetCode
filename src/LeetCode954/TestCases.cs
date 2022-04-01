using FluentAssertions;
using Xunit;

namespace LeetCode954
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.CanReorderDoubled(new[] { 3, 1, 3, 6 });
            result.Should().BeFalse();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.CanReorderDoubled(new[] { 2, 1, 2, 6 });
            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.CanReorderDoubled(new[] { 4, -2, 2, -4 });
            result.Should().BeTrue();
        }
    }
}
