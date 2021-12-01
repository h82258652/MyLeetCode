using FluentAssertions;
using Xunit;

namespace LeetCode034
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 })]
        [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 6, new[] { -1, -1 })]
        [InlineData(new int[] { }, 0, new[] { -1, -1 })]
        [InlineData(new[] { 1 }, 1, new[] { 0, 0 })]
        public void Test(int[] nums, int target, int[] assertResult)
        {
            var solution = new Solution();
            var result = solution.SearchRange(nums, target);
            result.Should().Equal(assertResult);
        }
    }
}
