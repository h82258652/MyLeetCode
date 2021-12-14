using FluentAssertions;
using Xunit;

namespace LeetCode414
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 3, 2, 1 }, 1)]
        [InlineData(new[] { 1, 2 }, 2)]
        [InlineData(new[] { 2, 2, 3, 1 }, 1)]
        public void Test(int[] nums, int expected)
        {
            var solution = new Solution();
            var result = solution.ThirdMax(nums);
            result.Should().Be(expected);
        }
    }
}
