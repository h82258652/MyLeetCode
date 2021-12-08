using FluentAssertions;
using Xunit;

namespace LeetCode413
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, 3)]
        [InlineData(new[] { 1 }, 0)]
        public void Test(int[] nums, int assertResult)
        {
            var solution = new Solution();
            var result = solution.NumberOfArithmeticSlices(nums);
            result.Should().Be(assertResult);
        }
    }
}
