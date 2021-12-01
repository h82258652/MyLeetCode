using System.Collections.Generic;
using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode120
{
    public class TestCases
    {
        [Theory]
        [InlineData("[[2],[3,4],[6,5,7],[4,1,8,3]]", 11)]
        [InlineData("[[-10]]", -10)]
        public void Test(string triangleJson, int assertResult)
        {
            var triangle = JsonSerializer.Deserialize<IList<IList<int>>>(triangleJson);
            var solution = new Solution();
            var result = solution.MinimumTotal(triangle);
            result.Should().Be(assertResult);
        }
    }
}
