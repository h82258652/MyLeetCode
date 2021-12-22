using FluentAssertions;
using Xunit;

namespace JianZhi13
{
    public class TestCases
    {
        [Theory]
        [InlineData(2, 3, 1, 3)]
        [InlineData(3, 1, 0, 1)]
        [InlineData(16, 8, 4, 15)]
        public void Test(int m, int n, int k, int excepted)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var count = solution.MovingCount(m, n, k);

            // Assert
            count.Should().Be(excepted);
        }
    }
}
