using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode145
{
    public class TestCases
    {
        [Theory]
        [InlineData("[1,null,2,3]", new[] { 3, 2, 1 })]
        public void Test(string rootJson, int[] excepted)
        {
            var rootArray = JsonSerializer.Deserialize<int?[]>(rootJson);
            var root = TreeNode.Create(rootArray);
            var solution = new Solution();
            var result = solution.PostorderTraversal(root);
            result.Should().Equal(excepted);
        }
    }
}
