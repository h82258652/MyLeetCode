using FluentAssertions;
using Xunit;

namespace JianZhi16
{
    public class TestCases
    {
        [Theory]
        [InlineData(2.00000, 10, 1024.00000)]
        [InlineData(2.10000, 3, 9.26100)]
        [InlineData(2.00000, -2, 0.25000)]
        [InlineData(2.00000, -2147483648, 0.0)]
        [InlineData(1.00000, -2147483648, 1.0)]
        [InlineData(-1.00000, -2147483648, 1.0)]
        [InlineData(34.00515, -3, 0)]
        public void Test(double x, int n, double expected)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var pow = solution.MyPow(x, n);

            // Assert
            pow.Should().BeApproximately(expected, 0.0001);
        }
    }
}
