using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode1828
{
    public class TestCases
    {
        [Theory]
        [InlineData("[[1,3],[3,3],[5,3],[2,2]]", "[[2,3,1],[4,3,1],[1,1,2]]", new[] { 3, 2, 2 })]
        [InlineData("[[1,1],[2,2],[3,3],[4,4],[5,5]]", "[[1,2,2],[2,2,2],[4,3,2],[4,3,3]]", new[] { 2, 3, 2, 4 })]
        public void Test(string pointsJson, string queriesJson, int[] expected)
        {
            var points = JsonSerializer.Deserialize<int[][]>(pointsJson);
            var queries = JsonSerializer.Deserialize<int[][]>(queriesJson);
            var solution = new Solution();
            var result = solution.CountPoints(points, queries);
            result.Should().Equal(expected);
        }
    }
}
