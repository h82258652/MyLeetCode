using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode200
{
    public class TestCases
    {
        [Theory]
        [InlineData(@"[[""1"",""1"",""1"",""1"",""0""],
                       [""1"",""1"",""0"",""1"",""0""],
                       [""1"",""1"",""0"",""0"",""0""],
                       [""0"",""0"",""0"",""0"",""0""]]", 1)]
        [InlineData(@"[[""1"",""1"",""0"",""0"",""0""],
                       [""1"",""1"",""0"",""0"",""0""],
                       [""0"",""0"",""1"",""0"",""0""],
                       [""0"",""0"",""0"",""1"",""1""]]", 3)]
        public void Test(string gridJson, int assertResult)
        {
            var grid = JsonSerializer.Deserialize<char[][]>(gridJson);
            var solution = new Solution();
            var result = solution.NumIslands(grid);
            result.Should().Be(assertResult);
        }
    }
}
