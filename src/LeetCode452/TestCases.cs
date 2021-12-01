using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode452
{
    public class TestCases
    {
        [Theory]
        [InlineData("[[10,16],[2,8],[1,6],[7,12]]", 2)]
        [InlineData("[[1,2],[3,4],[5,6],[7,8]]", 4)]
        [InlineData("[[1,2],[2,3],[3,4],[4,5]]", 2)]
        [InlineData("[[1,2]]", 1)]
        [InlineData("[[2,3],[2,3]]", 1)]
        public void Test(string pointsJson, int assertResult)
        {
            var points = JsonSerializer.Deserialize<int[][]>(pointsJson);
            var solution = new Solution();
            var result = solution.FindMinArrowShots(points);
            result.Should().Be(assertResult);
        }
    }
}
