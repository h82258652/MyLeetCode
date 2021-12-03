using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode257
{
    public class TestCases
    {
        [Theory]
        [InlineData("[1,2,3,null,5]", new[] { "1->2->5", "1->3" })]
        [InlineData("[1]", new[] { "1" })]
        public void Test(string rootJson, string[] assertResult)
        {
            var rootArray = JsonSerializer.Deserialize<int?[]>(rootJson);
            var root = TreeNode.Create(rootArray);
            var solution = new Solution();
            var result = solution.BinaryTreePaths(root);
            result.Should().Equal(assertResult);
        }
    }
}
