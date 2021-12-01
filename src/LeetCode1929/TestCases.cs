using FluentAssertions;
using Xunit;

namespace LeetCode1929
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 1 }, new[] { 1, 2, 1, 1, 2, 1 })]
        [InlineData(new[] { 1, 3, 2, 1 }, new[] { 1, 3, 2, 1, 1, 3, 2, 1 })]
        public void Test(int[] nums, int[] assertResult)
        {
            var solution = new Solution();
            var result = solution.GetConcatenation(nums);
            result.Should().Equal(assertResult);
        }
    }
}
