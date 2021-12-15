using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode566
{
    public class TestCases
    {
        [Theory]
        [InlineData("[[1,2],[3,4]]", 1, 4, "[[1,2,3,4]]")]
        [InlineData("[[1,2],[3,4]]", 2, 4, "[[1,2],[3,4]]")]
        public void Test(string matJson, int r, int c, string expectationJson)
        {
            var mat = JsonSerializer.Deserialize<int[][]>(matJson);
            var expectation = JsonSerializer.Deserialize<int[][]>(expectationJson);
            var solution = new Solution();
            var result = solution.MatrixReshape(mat, r, c);
            result.Should().BeEquivalentTo(expectation);
        }
    }
}
