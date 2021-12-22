using FluentAssertions;
using Xunit;

namespace JianZhi64
{
    public class TestCases
    {
        [Theory]
        [InlineData(3, 6)]
        [InlineData(9, 45)]
        public void Test(int n, int expected)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var sum = solution.SumNums(n);

            // Assert
            sum.Should().Be(expected);
        }
    }
}
