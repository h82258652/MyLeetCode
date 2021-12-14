using FluentAssertions;
using Xunit;

namespace LeetCode283
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
        [InlineData(new[] { 1, 0 }, new[] { 1, 0 })]
        [InlineData(new[] { 1, 0, 1 }, new[] { 1, 1, 0 })]
        public void Test(int[] nums, int[] expected)
        {
            var solution = new Solution();
            solution.MoveZeroes(nums);
            nums.Should().Equal(expected);
        }
    }
}
