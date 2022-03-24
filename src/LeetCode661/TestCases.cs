using FluentAssertions;
using Xunit;

namespace LeetCode661
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var img = new[]
            {
                new[] { 1, 1, 1 },
                new[] { 1, 0, 1 },
                new[] { 1, 1, 1 }
            };
            var result = solution.ImageSmoother(img);
            result.Should().BeEquivalentTo(new[]
            {
                new[] { 0, 0, 0 },
                new[] { 0, 0, 0 },
                new[] { 0, 0, 0 }
            }, options => options.WithStrictOrdering());
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var img = new[]
            {
                new[] { 100, 200, 100 },
                new[] { 200, 50, 200 },
                new[] { 100, 200, 100 }
            };
            var result = solution.ImageSmoother(img);
            result.Should().BeEquivalentTo(new[]
            {
                new[] { 137, 141, 137 },
                new[] { 141, 138, 141 },
                new[] { 137, 141, 137 }
            }, options => options.WithStrictOrdering());
        }
    }
}
