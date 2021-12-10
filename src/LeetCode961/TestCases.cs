using FluentAssertions;
using Xunit;

namespace LeetCode961
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 3 }, 3)]
        [InlineData(new[] { 2, 1, 2, 5, 3, 2 }, 2)]
        [InlineData(new[] { 5, 1, 5, 2, 5, 3, 5, 4 }, 5)]
        public void Test(int[] nums, int expected)
        {
            var solution = new Solution();
            var result = solution.RepeatedNTimes(nums);
            result.Should().Be(expected);
        }
    }
}
