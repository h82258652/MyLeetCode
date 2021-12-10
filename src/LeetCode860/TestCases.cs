using FluentAssertions;
using Xunit;

namespace LeetCode860
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 5, 5, 5, 10, 20 }, true)]
        [InlineData(new[] { 5, 5, 10, 10, 20 }, false)]
        [InlineData(new[] { 5, 5, 10 }, true)]
        [InlineData(new[] { 10, 10 }, false)]
        public void Test(int[] bills, bool expected)
        {
            var solution = new Solution();
            var result = solution.LemonadeChange(bills);
            result.Should().Be(expected);
        }
    }
}
