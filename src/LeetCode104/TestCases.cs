using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode104
{
    public class TestCases
    {
        [Theory]
        [InlineData("[3,9,20,null,null,15,7]", 3)]
        public void Test(string rootJson, int assertResult)
        {
            var rootArray = JsonSerializer.Deserialize<int?[]>(rootJson);
            var root = TreeNode.Create(rootArray);
            var solution = new Solution();
            var result = solution.MaxDepth(root);
            result.Should().Be(assertResult);
        }
    }
}
