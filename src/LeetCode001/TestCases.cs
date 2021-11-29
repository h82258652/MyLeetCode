using FluentAssertions;
using Xunit;

namespace LeetCode001
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void Test(int[] nums, int target, int[] assertResult)
        {
            var solution = new Solution();
            var result = solution.TwoSum(nums, target);
            result.Should().Equal(assertResult);
        }
    }
}
