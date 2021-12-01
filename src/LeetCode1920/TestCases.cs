using FluentAssertions;
using Xunit;

namespace LeetCode1920
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 0, 2, 1, 5, 3, 4 }, new[] { 0, 1, 2, 4, 5, 3 })]
        [InlineData(new[] { 5, 0, 1, 2, 3, 4 }, new[] { 4, 5, 0, 1, 2, 3 })]
        public void Test(int[] nums, int[] assertResult)
        {
            var solution = new Solution();
            var result = solution.BuildArray(nums);
            result.Should().Equal(assertResult);
        }
    }
}
