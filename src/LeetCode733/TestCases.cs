using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode733
{
    public class TestCases
    {
        [Theory]
        [InlineData(@"[[1,1,1],
                       [1,1,0],
                       [1,0,1]]", 1, 1, 2,
                    @"[[2,2,2],
                       [2,2,0],
                       [2,0,1]]")]
        public void Test(string imageJson, int sr, int sc, int newColor, string exceptedJson)
        {
            var image = JsonSerializer.Deserialize<int[][]>(imageJson);
            var excepted = JsonSerializer.Deserialize<int[][]>(exceptedJson);
            var solution = new Solution();
            var result = solution.FloodFill(image, sr, sc, newColor);
            result.Should().BeEquivalentTo(excepted);
        }
    }
}
