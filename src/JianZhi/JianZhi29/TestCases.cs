using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace JianZhi29
{
    public class TestCases
    {
        [Theory]
        [InlineData(@"[[1,2,3],
                       [4,5,6],
                       [7,8,9]]", new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 })]
        [InlineData(@"[[1,2,3,4],
                       [5,6,7,8],
                       [9,10,11,12]]", new[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 })]
        public void Test(string matrixJson, int[] expected)
        {
            // Arrange
            var matrix = JsonSerializer.Deserialize<int[][]>(matrixJson);
            var solution = new Solution();

            // Act
            var result = solution.SpiralOrder(matrix);

            // Assert
            result.Should().Equal(expected);
        }
    }
}
