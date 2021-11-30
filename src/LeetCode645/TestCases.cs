using FluentAssertions;
using Xunit;

namespace LeetCode645
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 2, 4 }, new[] { 2, 3 })]
        [InlineData(new[] { 1, 1 }, new[] { 1, 2 })]
        public void Test(int[] nums, int[] assertResult)
        {
            var solution = new Solution();
            var result = solution.FindErrorNums(nums);
            result.Should().Equal(assertResult);
        }
    }
}
