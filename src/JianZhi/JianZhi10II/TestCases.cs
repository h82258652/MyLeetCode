using FluentAssertions;
using Xunit;

namespace JianZhi10II
{
    public class TestCases
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(7, 21)]
        [InlineData(0, 1)]
        public void Test(int n, int excepted)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.NumWays(n);

            // Assert
            result.Should().Be(excepted);
        }
    }
}
