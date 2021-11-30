using FluentAssertions;
using Xunit;

namespace LeetCode977
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { -4, -1, 0, 3, 10 }, new[] { 0, 1, 9, 16, 100 })]
        [InlineData(new[] { -7, -3, 2, 3, 11 }, new[] { 4, 9, 9, 49, 121 })]
        public void Test(int[] nums, int[] assertResult)
        {
            var solution = new Solution();
            var result = solution.SortedSquares(nums);
            result.Should().Equal(assertResult);
        }
    }
}
