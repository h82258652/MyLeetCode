using FluentAssertions;
using Xunit;

namespace LeetCode1460
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 2, 4, 1, 3 }, true)]
        [InlineData(new[] { 7 }, new[] { 7 }, true)]
        [InlineData(new[] { 3, 7, 9 }, new[] { 3, 7, 11 }, false)]
        public void Test(int[] target, int[] arr, bool expected)
        {
            var solution = new Solution();
            var result = solution.CanBeEqual(target, arr);
            result.Should().Be(expected);
        }
    }
}
