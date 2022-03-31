using FluentAssertions;
using Xunit;

namespace LeetCode2154
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new[] { 5, 3, 6, 1, 12 };
            var original = 3;
            var result = solution.FindFinalValue(nums, original);
            result.Should().Be(24);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new[] { 2, 7, 9 };
            var original = 4;
            var result = solution.FindFinalValue(nums, original);
            result.Should().Be(4);
        }
    }
}
