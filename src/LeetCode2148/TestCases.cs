using FluentAssertions;
using Xunit;

namespace LeetCode2148
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new[] { 11, 7, 2, 15 };
            var result = solution.CountElements(nums);
            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new[] { -3, 3, 3, 90 };
            var result = solution.CountElements(nums);
            result.Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var nums = new[] { 0 };
            var result = solution.CountElements(nums);
            result.Should().Be(0);
        }
    }
}
