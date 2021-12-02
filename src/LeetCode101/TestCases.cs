using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode101
{
    public class TestCases
    {
        [Theory]
        [InlineData("[1,2,2,3,4,4,3]", true)]
        [InlineData("[1,2,2,null,3,null,3]", false)]
        public void Test(string rootJson, bool assertResult)
        {
            var rootArray = JsonSerializer.Deserialize<int?[]>(rootJson);
            var root = TreeNode.Create(rootArray);
            var solution = new Solution();
            var result = solution.IsSymmetric(root);
            result.Should().Be(assertResult);
        }
    }
}
