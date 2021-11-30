using FluentAssertions;
using Xunit;

namespace LeetCode119
{
    public class TestCases
    {
        [Theory]
        [InlineData(3, new[] { 1, 3, 3, 1 })]
        [InlineData(0, new[] { 1 })]
        [InlineData(1, new[] { 1, 1 })]
        public void Test(int rowIndex, int[] assertResult)
        {
            var solution = new Solution();
            var result = solution.GetRow(rowIndex);
            result.Should().Equal(assertResult);
        }
    }
}
