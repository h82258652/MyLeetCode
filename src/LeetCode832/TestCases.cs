using FluentAssertions;
using Xunit;

namespace LeetCode832
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var image = new[]
            {
                new[] { 1, 1, 0 },
                new[] { 1, 0, 1 },
                new[] { 0, 0, 0 }
            };
            var result = solution.FlipAndInvertImage(image);
            var expectation = new[]
            {
                new[] { 1, 0, 0 },
                new[] { 0, 1, 0 },
                new[] { 1, 1, 1 }
            };
            result.Should().BeEquivalentTo(expectation);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var image = new[]
            {
                new[] { 1, 1, 0, 0 },
                new[] { 1, 0, 0, 1 },
                new[] { 0, 1, 1, 1 },
                new[] { 1, 0, 1, 0 }
            };
            var result = solution.FlipAndInvertImage(image);
            var expectation = new[]
            {
                new[] { 1, 1, 0, 0 },
                new[] { 0, 1, 1, 0 },
                new[] { 0, 0, 0, 1 },
                new[] { 1, 0, 1, 0 }
            };
            result.Should().BeEquivalentTo(expectation);
        }
    }
}
