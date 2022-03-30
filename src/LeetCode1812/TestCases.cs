using FluentAssertions;
using Xunit;

namespace LeetCode1812
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.SquareIsWhite("a1");
            result.Should().BeFalse();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.SquareIsWhite("h3");
            result.Should().BeTrue();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.SquareIsWhite("c7");
            result.Should().BeFalse();
        }
    }
}
