using FluentAssertions;
using Xunit;

namespace LeetCode191
{
    public class TestCases
    {
        [Theory]
        [InlineData(0b00000000000000000000000000001011u, 3)]
        [InlineData(0b00000000000000000000000010000000u, 1)]
        [InlineData(0b11111111111111111111111111111101u, 31)]
        public void Test(uint n, int assertResult)
        {
            var solution = new Solution();
            var result = solution.HammingWeight(n);
            result.Should().Be(assertResult);
        }
    }
}
