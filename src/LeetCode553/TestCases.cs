using FluentAssertions;
using Xunit;

namespace LeetCode553
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.OptimalDivision(new[] { 1000, 100, 10, 2 });
            result.Should().Be("1000/(100/10/2)");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.OptimalDivision(new[] { 2, 3, 4 });
            result.Should().Be("2/(3/4)");
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.OptimalDivision(new[] { 2 });
            result.Should().Be("2");
        }
    }
}
