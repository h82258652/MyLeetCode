using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode997
{
    public class TestCases
    {
        [Theory]
        [InlineData(2, "[[1,2]]", 2)]
        [InlineData(3, "[[1,3],[2,3]]", 3)]
        [InlineData(3, "[[1,3],[2,3],[3,1]]", -1)]
        [InlineData(3, "[[1,2],[2,3]]", -1)]
        [InlineData(4, "[[1,3],[1,4],[2,3],[2,4],[4,3]]", 3)]
        public void Test(int n, string trustJson, int excepted)
        {
            var trust = JsonSerializer.Deserialize<int[][]>(trustJson);
            var solution = new Solution();
            var result = solution.FindJudge(n, trust);
            result.Should().Be(excepted);
        }
    }
}
