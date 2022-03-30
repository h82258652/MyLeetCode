using FluentAssertions;
using Xunit;

namespace LeetCode1725
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var rectangles = new[]
            {
                new[] { 5, 8 },
                new[] { 3, 9 },
                new[] { 5, 12 },
                new[] { 16, 5 }
            };
            var result = solution.CountGoodRectangles(rectangles);
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var rectangles = new[]
            {
                new[] { 2, 3 },
                new[] { 3, 7 },
                new[] { 4, 3 },
                new[] { 3, 7 }
            };
            var result = solution.CountGoodRectangles(rectangles);
            result.Should().Be(3);
        }
    }
}
