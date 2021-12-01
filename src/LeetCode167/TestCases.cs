using FluentAssertions;
using Xunit;

namespace LeetCode167
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 1, 2 })]
        [InlineData(new[] { 2, 3, 4 }, 6, new[] { 1, 3 })]
        [InlineData(new[] { -1, 0 }, -1, new[] { 1, 2 })]
        public void Test(int[] numbers, int target, int[] assertResult)
        {
            var solution = new Solution();
            var result = solution.TwoSum(numbers, target);
            result.Should().Equal(assertResult);
        }
    }
}
