using FluentAssertions;
using Xunit;

namespace LeetCode806
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var widths = new[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            var s = "abcdefghijklmnopqrstuvwxyz";
            var result = solution.NumberOfLines(widths, s);
            result.Should().Equal(3, 60);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var widths = new[] { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            var s = "bbbcccdddaaa";
            var result = solution.NumberOfLines(widths, s);
            result.Should().Equal(2, 4);
        }
    }
}
