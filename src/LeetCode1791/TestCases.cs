using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode1791
{
    public class TestCases
    {
        [Theory]
        [InlineData("[[1,2],[2,3],[4,2]]", 2)]
        [InlineData("[[1,2],[5,1],[1,3],[1,4]]", 1)]
        public void Test(string edgesJson, int expected)
        {
            var edges = JsonSerializer.Deserialize<int[][]>(edgesJson);
            var solution = new Solution();
            var result = solution.FindCenter(edges);
            result.Should().Be(expected);
        }
    }
}
