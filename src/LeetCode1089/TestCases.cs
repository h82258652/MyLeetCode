using FluentAssertions;
using Xunit;

namespace LeetCode1089
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 0, 2, 3, 0, 4, 5, 0 }, new[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
        public void Test(int[] arr, int[] assertResult)
        {
            var solution = new Solution();
            solution.DuplicateZeros(arr);
            arr.Should().Equal(assertResult);
        }
    }
}
