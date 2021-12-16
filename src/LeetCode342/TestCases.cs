using FluentAssertions;
using Xunit;

namespace LeetCode342
{
    public class TestCases
    {
        [Theory]
        [InlineData(16, true)]
        [InlineData(5, false)]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [InlineData(8, false)]
        public void Test(int n, bool expected)
        {
            var solution = new Solution();
            var result = solution.IsPowerOfFour(n);
            result.Should().Be(expected);
        }
    }
}
