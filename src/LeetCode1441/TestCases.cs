using FluentAssertions;
using Xunit;

namespace LeetCode1441
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 3 }, 3, new[] { "Push", "Push", "Pop", "Push" })]
        [InlineData(new[] { 1, 2, 3 }, 3, new[] { "Push", "Push", "Push" })]
        [InlineData(new[] { 1, 2 }, 4, new[] { "Push", "Push" })]
        [InlineData(new[] { 2, 3, 4 }, 4, new[] { "Push", "Pop", "Push", "Push", "Push" })]
        public void Test(int[] target, int n, string[] assertResult)
        {
            var solution = new Solution();
            var result = solution.BuildArray(target, n);
            result.Should().Equal(assertResult);
        }
    }
}
