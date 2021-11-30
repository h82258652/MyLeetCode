using FluentAssertions;
using Xunit;

namespace LeetCode485
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 1, 0, 1, 1, 1 }, 3)]
        public void Test(int[] nums, int assertResult)
        {
            var solution = new Solution();
            var result = solution.FindMaxConsecutiveOnes(nums);
            result.Should().Be(assertResult);
        }
    }
}
