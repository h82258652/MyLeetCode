using FluentAssertions;
using Xunit;

namespace JianZhi15
{
    public class TestCases
    {
        [Theory]
        [InlineData(0b00000000000000000000000000001011u, 3)]
        [InlineData(0b00000000000000000000000010000000u, 1)]
        [InlineData(0b11111111111111111111111111111101u, 31)]
        public void Test(uint n, int expected)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.HammingWeight(n);

            // Assert
            result.Should().Be(expected);
        }
    }
}
