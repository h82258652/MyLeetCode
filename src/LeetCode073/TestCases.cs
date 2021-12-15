using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode073
{
    public class TestCases
    {
        [Theory]
        [InlineData(@"[[1,1,1],
                       [1,0,1],
                       [1,1,1]]",
                    @"[[1,0,1],
                       [0,0,0],
                       [1,0,1]]")]
        [InlineData(@"[[0,1,2,0],
                       [3,4,5,2],
                       [1,3,1,5]]",
                    @"[[0,0,0,0],
                       [0,4,5,0],
                       [0,3,1,0]]")]
        public void Test(string matrixJson, string expectationJson)
        {
            var matrix = JsonSerializer.Deserialize<int[][]>(matrixJson);
            var expectation = JsonSerializer.Deserialize<int[][]>(expectationJson);
            var solution = new Solution();
            solution.SetZeroes(matrix);
            matrix.Should().BeEquivalentTo(expectation);
        }
    }
}
