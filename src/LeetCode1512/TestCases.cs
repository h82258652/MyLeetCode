using FluentAssertions;
using Xunit;

namespace LeetCode1512
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 1, 1, 3 }, 4)]
        [InlineData(new[] { 1, 1, 1, 1 }, 6)]
        [InlineData(new[] { 1, 2, 3 }, 0)]
        public void Test(int[] nums, int assertResult)
        {
            var solution = new Solution();
            var result = solution.NumIdenticalPairs(nums);
            result.Should().Be(assertResult);
        }
    }
}
