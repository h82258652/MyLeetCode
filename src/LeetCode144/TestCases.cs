using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode144
{
    public class TestCases
    {
        [Theory]
        [InlineData("[1,null,2,3]", new[] { 1, 2, 3 })]
        [InlineData("[]", new int[] { })]
        [InlineData("[1]", new[] { 1 })]
        [InlineData("[1,2]", new[] { 1, 2 })]
        [InlineData("[1,null,2]", new[] { 1, 2 })]
        public void Test(string rootJson, int[] assertResult)
        {
            var rootArray = JsonSerializer.Deserialize<int?[]>(rootJson);
            var root = TreeNode.Create(rootArray);
            var solution = new Solution();
            var result = solution.PreorderTraversal(root);
            result.Should().Equal(assertResult);
        }
    }
}
