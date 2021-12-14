using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode695
{
    public class TestCases
    {
        [Theory]
        [InlineData(@"[[0,0,1,0,0,0,0,1,0,0,0,0,0],
                       [0,0,0,0,0,0,0,1,1,1,0,0,0],
                       [0,1,1,0,1,0,0,0,0,0,0,0,0],
                       [0,1,0,0,1,1,0,0,1,0,1,0,0],
                       [0,1,0,0,1,1,0,0,1,1,1,0,0],
                       [0,0,0,0,0,0,0,0,0,0,1,0,0],
                       [0,0,0,0,0,0,0,1,1,1,0,0,0],
                       [0,0,0,0,0,0,0,1,1,0,0,0,0]]", 6)]
        [InlineData(@"[[0,0,0,0,0,0,0,0]]", 0)]
        public void Test(string gridJson, int excepted)
        {
            var grid = JsonSerializer.Deserialize<int[][]>(gridJson);
            Solution solution = new Solution();
            var result = solution.MaxAreaOfIsland(grid);
            result.Should().Be(excepted);
        }
    }
}
