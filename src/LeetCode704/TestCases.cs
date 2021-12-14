using FluentAssertions;
using Xunit;

namespace LeetCode704
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
        [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
        [InlineData(new[] { 5 }, 5, 0)]
        public void Test(int[] nums, int target, int expected)
        {
            var solution = new Solution();
            var result = solution.Search(nums, target);
            result.Should().Be(expected);
        }
    }
}
