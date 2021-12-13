using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode807
{
    public class TestCases
    {
        [Theory]
        [InlineData("[[3,0,8,4],[2,4,5,7],[9,2,6,3],[0,3,1,0]]", 35)]
        [InlineData("[[0,0,0],[0,0,0],[0,0,0]]", 0)]
        public void Test(string gridJson, int excepted)
        {
            var grid = JsonSerializer.Deserialize<int[][]>(gridJson);
            var solution = new Solution();
            var result = solution.MaxIncreaseKeepingSkyline(grid);
            result.Should().Be(excepted);
        }
    }
}
