using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode419
{
    public class TestCases
    {
        [Theory]
        [InlineData(@"[[""X"",""."",""."",""X""],
                       [""."",""."",""."",""X""],
                       [""."",""."",""."",""X""]]", 2)]
        [InlineData(@"[["".""]]", 0)]
        public void Test(string boardJson, int excepted)
        {
            var board = JsonSerializer.Deserialize<char[][]>(boardJson);
            var solution = new Solution();
            var result = solution.CountBattleships(board);
            result.Should().Be(excepted);
        }
    }
}
