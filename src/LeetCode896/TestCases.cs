using FluentAssertions;
using Xunit;

namespace LeetCode896
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 2, 3 }, true)]
        [InlineData(new[] { 6, 5, 4, 4 }, true)]
        [InlineData(new[] { 1, 3, 2 }, false)]
        [InlineData(new[] { 1, 2, 4, 5 }, true)]
        [InlineData(new[] { 1, 1, 1 }, true)]
        [InlineData(new[] { 1, 1, 0 }, true)]
        public void Test(int[] nums, bool expected)
        {
            var solution = new Solution();
            var result = solution.IsMonotonic(nums);
            result.Should().Be(expected);
        }
    }
}
