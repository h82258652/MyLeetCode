using FluentAssertions;
using Xunit;

namespace LeetCode682
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.CalPoints(new[] { "5", "2", "C", "D", "+" });
            result.Should().Be(30);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.CalPoints(new[] { "5", "-2", "4", "C", "D", "9", "+", "+" });
            result.Should().Be(27);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.CalPoints(new[] { "1" });
            result.Should().Be(1);
        }
    }
}
