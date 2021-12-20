using FluentAssertions;
using Xunit;

namespace JianZhi17
{
    public class TestCases
    {
        [Theory]
        [InlineData(1, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        public void Test(int n, int[] expected)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var numbers = solution.PrintNumbers(n);

            // Assert
            numbers.Should().Equal(expected);
        }
    }
}
