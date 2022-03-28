using FluentAssertions;
using Xunit;

namespace LeetCode643
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new[] { 1, 12, -5, -6, 50, 3 };
            var k = 4;
            var result = solution.FindMaxAverage(nums, k);
            result.Should().Be(12.75);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new[] { 5 };
            var k = 1;
            var result = solution.FindMaxAverage(nums, k);
            result.Should().Be(5);
        }
    }
}
