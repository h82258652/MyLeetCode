using FluentAssertions;
using Xunit;

namespace LeetCode1913
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new[] { 5, 6, 2, 7, 4 };
            var result = solution.MaxProductDifference(nums);
            result.Should().Be(34);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new[] { 4, 2, 5, 9, 7, 4, 8 };
            var result = solution.MaxProductDifference(nums);
            result.Should().Be(64);
        }
    }
}
