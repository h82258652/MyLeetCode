using FluentAssertions;
using Xunit;

namespace LeetCode169
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 3, 2, 3 }, 3)]
        [InlineData(new[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        [InlineData(new[] { -1, 1, 1, 1, 2, 1 }, 1)]
        public void Test(int[] nums, int assertResult)
        {
            var solution = new Solution();
            var result = solution.MajorityElement(nums);
            result.Should().Be(assertResult);
        }
    }
}
