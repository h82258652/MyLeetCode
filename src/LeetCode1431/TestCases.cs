using FluentAssertions;
using Xunit;

namespace LeetCode1431
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 2, 3, 5, 1, 3 }, 3, new[] { true, true, true, false, true })]
        [InlineData(new[] { 4, 2, 1, 1, 2 }, 1, new[] { true, false, false, false, false })]
        [InlineData(new[] { 12, 1, 12 }, 10, new[] { true, false, true })]
        public void Test(int[] candies, int extraCandies, bool[] excepted)
        {
            var solution = new Solution();
            var result = solution.KidsWithCandies(candies, extraCandies);
            result.Should().Equal(excepted);
        }
    }
}
