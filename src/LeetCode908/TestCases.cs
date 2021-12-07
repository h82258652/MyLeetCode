using FluentAssertions;
using Xunit;

namespace LeetCode908
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1 }, 0, 0)]
        [InlineData(new[] { 0, 10 }, 2, 6)]
        [InlineData(new[] { 1, 3, 6 }, 3, 0)]
        public void Test(int[] nums, int k, int assertResult)
        {
            var solution = new Solution();
            var result = solution.SmallestRangeI(nums, k);
            result.Should().Be(assertResult);
        }
    }
}
