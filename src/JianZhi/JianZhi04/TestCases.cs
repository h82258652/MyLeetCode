using FluentAssertions;
using Xunit;

namespace JianZhi04
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var solution = new Solution();
            var matrix = new[]
            {
                new[] { 1, 4, 7, 11, 15 },
                new[] { 2, 5, 8, 12, 19 },
                new[] { 3, 6, 9, 16, 22 },
                new[] { 10, 13, 14, 17, 24 },
                new[] { 18, 21, 23, 26, 30 }
            };

            // Act
            var result1 = solution.FindNumberIn2DArray(matrix, 5);
            var result2 = solution.FindNumberIn2DArray(matrix, 20);

            // Assert
            result1.Should().BeTrue();
            result2.Should().BeFalse();
        }
    }
}
