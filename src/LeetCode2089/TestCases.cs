using FluentAssertions;
using Xunit;

namespace LeetCode2089
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 5, 2, 3 }, 2, new[] { 1, 2 })]
        [InlineData(new[] { 1, 2, 5, 2, 3 }, 3, new[] { 3 })]
        [InlineData(new[] { 1, 2, 5, 2, 3 }, 5, new[] { 4 })]
        public void Test(int[] nums, int target, int[] expected)
        {
            var solution = new Solution();
            var result = solution.TargetIndices(nums, target);
            result.Should().Equal(expected);
        }
    }
}
