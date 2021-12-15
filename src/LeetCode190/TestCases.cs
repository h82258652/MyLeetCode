using FluentAssertions;
using Xunit;

namespace LeetCode190
{
    public class TestCases
    {
        [Theory]
        [InlineData(0b00000010100101000001111010011100u, 0b00111001011110000010100101000000u)]
        [InlineData(0b11111111111111111111111111111101u, 0b10111111111111111111111111111111u)]
        public void Test(uint n, uint excepted)
        {
            var solution = new Solution();
            var result = solution.reverseBits(n);
            result.Should().Be(excepted);
        }
    }
}
