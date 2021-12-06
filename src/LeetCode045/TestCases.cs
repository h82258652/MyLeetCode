using FluentAssertions;
using Xunit;

namespace LeetCode045
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 2, 3, 1, 1, 4 }, 2)]
        [InlineData(new[] { 2, 3, 0, 1, 4 }, 2)]
        public void Test(int[] nums, int assertResult)
        {
            var solution = new Solution();
            var result = solution.Jump(nums);
            result.Should().Be(assertResult);
        }
    }
}
