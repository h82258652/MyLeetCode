using FluentAssertions;
using Xunit;

namespace LeetCode1748
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 2 }, 4)]
        [InlineData(new[] { 1, 1, 1, 1, 1 }, 0)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 15)]
        public void Test(int[] nums, int excepted)
        {
            var solution = new Solution();
            var result = solution.SumOfUnique(nums);
            result.Should().Be(excepted);
        }
    }
}
