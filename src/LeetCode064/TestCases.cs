using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode064
{
    public class TestCases
    {
        [Theory]
        [InlineData("[[1,3,1],[1,5,1],[4,2,1]]", 7)]
        [InlineData("[[1,2,3],[4,5,6]]", 12)]
        public void Test(string gridJson, int assertResult)
        {
            var grid = JsonSerializer.Deserialize<int[][]>(gridJson);
            var solution = new Solution();
            var result = solution.MinPathSum(grid);
            result.Should().Be(assertResult);
        }
    }
}
