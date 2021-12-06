using FluentAssertions;
using Xunit;

namespace LeetCode055
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 2, 3, 1, 1, 4 }, true)]
        [InlineData(new[] { 3, 2, 1, 0, 4 }, false)]
        [InlineData(new[] { 0, 2, 3 }, false)]
        public void Test(int[] nums, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.CanJump(nums);
            result.Should().Be(assertResult);
        }
    }
}
