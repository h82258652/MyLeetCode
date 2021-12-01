using FluentAssertions;
using Xunit;

namespace LeetCode1979
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 2, 5, 6, 9, 10 }, 2)]
        [InlineData(new[] { 7, 5, 6, 8, 3 }, 1)]
        [InlineData(new[] { 3, 3 }, 3)]
        public void Test(int[] nums, int assertResult)
        {
            var solution = new Solution();
            var result = solution.FindGCD(nums);
            result.Should().Be(assertResult);
        }
    }
}
