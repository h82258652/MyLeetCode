using FluentAssertions;
using Xunit;

namespace LeetCode2028
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 3, 2, 4, 3 }, 4, 2, new[] { 6, 6 })]
        [InlineData(new[] { 1, 5, 6 }, 3, 4, new[] { 2, 3, 2, 2 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 6, 4, new int[] { })]
        [InlineData(new[] { 1 }, 3, 1, new[] { 5 })]
        public void Test(int[] rolls, int mean, int n, int[] expectation)
        {
            var solution = new Solution();
            var result = solution.MissingRolls(rolls, mean, n);
            result.Should().BeEquivalentTo(expectation, options => options.WithoutStrictOrdering());
        }
    }
}
