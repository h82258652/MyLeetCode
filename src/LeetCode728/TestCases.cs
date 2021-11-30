using FluentAssertions;
using Xunit;

namespace LeetCode728
{
    public class TestCases
    {
        [Theory]
        [InlineData(1, 22, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 })]
        public void Test(int left, int right, int[] assertResult)
        {
            var solution = new Solution();
            var result = solution.SelfDividingNumbers(left, right);
            result.Should().Equal(assertResult);
        }
    }
}
