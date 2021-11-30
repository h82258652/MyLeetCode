using System.Collections.Generic;
using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode118
{
    public class TestCases
    {
        [Theory]
        [InlineData(5, "[[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]")]
        [InlineData(1, "[[1]]")]
        public void Test(int numRows, string assertResultJson)
        {
            var assertResult = JsonSerializer.Deserialize<IList<IList<int>>>(assertResultJson);
            var solution = new Solution();
            var result = solution.Generate(numRows);
            result.Should().BeEquivalentTo(assertResult);
        }
    }
}
