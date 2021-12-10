using FluentAssertions;
using Xunit;

namespace LeetCode2057
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 0, 1, 2 }, 0)]
        [InlineData(new[] { 4, 3, 2, 1 }, 2)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, -1)]
        [InlineData(new[] { 2, 1, 3, 5, 2 }, 1)]
        public void Test(int[] nums, int excepted)
        {
            var solution = new Solution();
            var result = solution.SmallestEqual(nums);
            result.Should().Be(excepted);
        }
    }
}
