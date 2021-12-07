using FluentAssertions;
using Xunit;

namespace LeetCode989
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 0, 0 }, 34, new[] { 1, 2, 3, 4 })]
        [InlineData(new[] { 2, 7, 4 }, 181, new[] { 4, 5, 5 })]
        [InlineData(new[] { 2, 1, 5 }, 806, new[] { 1, 0, 2, 1 })]
        public void Test(int[] num, int k, int[] assertResult)
        {
            var solution = new Solution();
            var result = solution.AddToArrayForm(num, k);
            result.Should().Equal(assertResult);
        }
    }
}
