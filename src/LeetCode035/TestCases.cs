using FluentAssertions;
using Xunit;

namespace LeetCode035
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new[] { 1, 3, 5, 6 }, 7, 4)]
        [InlineData(new[] { 1, 3, 5, 6 }, 0, 0)]
        [InlineData(new[] { 1 }, 0, 0)]
        public void Test(int[] nums, int target, int assertResult)
        {
            var solution = new Solution();
            var result = solution.SearchInsert(nums, target);
            result.Should().Be(assertResult);
        }
    }
}
