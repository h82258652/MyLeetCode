using FluentAssertions;
using Xunit;

namespace LeetCode868
{
    public class TestCases
    {
        [Theory]
        [InlineData(22, 2)]
        [InlineData(8, 0)]
        [InlineData(5, 2)]
        public void Test(int n, int expected)
        {
            var solution = new Solution();
            var result = solution.BinaryGap(n);
            result.Should().Be(expected);
        }
    }
}
