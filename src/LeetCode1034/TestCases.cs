using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode1034
{
    public class TestCases
    {
        [Theory]
        [InlineData("[[1,1],[1,2]]", 0, 0, 3, "[[3,3],[3,2]]")]
        [InlineData("[[1,2,2],[2,3,2]]", 0, 1, 3, "[[1,3,3],[2,3,3]]")]
        [InlineData("[[1,1,1],[1,1,1],[1,1,1]]", 1, 1, 2, "[[2,2,2],[2,1,2],[2,2,2]]")]
        [InlineData(@"[[2,1,3,2,1,1,2],
                       [1,2,3,1,2,1,2],
                       [1,2,1,2,2,2,2],
                       [2,1,2,2,2,2,2],
                       [2,3,3,3,2,1,2]]", 4, 4, 3,
                    @"[[2,1,3,2,1,1,3],
                       [1,2,3,1,3,1,3],
                       [1,2,1,3,2,3,3],
                       [2,1,3,3,2,3,3],
                       [2,3,3,3,3,1,3]]")]
        public void Test(string gridJson, int row, int col, int color, string assertResultJson)
        {
            var grid = JsonSerializer.Deserialize<int[][]>(gridJson);
            var assertResult = JsonSerializer.Deserialize<int[][]>(assertResultJson);
            var solution = new Solution();
            var result = solution.ColorBorder(grid, row, col, color);
            result.Should().BeEquivalentTo(assertResult);
        }
    }
}
