using FluentAssertions;
using Xunit;

namespace LeetCode198
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 1 }, 4)]
        [InlineData(new[] { 2, 7, 9, 3, 1 }, 12)]
        public void Test(int[] nums, int assertResult)
        {
            var solution = new Solution();
            var result = solution.Rob(nums);
            result.Should().Be(assertResult);
        }
    }
}
