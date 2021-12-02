using FluentAssertions;
using Xunit;

namespace LeetCode506
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 5, 4, 3, 2, 1 }, new[] { "Gold Medal", "Silver Medal", "Bronze Medal", "4", "5" })]
        [InlineData(new[] { 10, 3, 8, 9, 4 }, new[] { "Gold Medal", "5", "Bronze Medal", "Silver Medal", "4" })]
        public void Test(int[] score, string[] assertResult)
        {
            var solution = new Solution();
            var result = solution.FindRelativeRanks(score);
            result.Should().Equal(assertResult);
        }
    }
}
