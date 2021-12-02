using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode938
{
    public class TestCases
    {
        [Theory]
        [InlineData("[10,5,15,3,7,null,18]", 7, 15, 32)]
        [InlineData("[10,5,15,3,7,13,18,1,null,6]", 6, 10, 23)]
        public void Test(string rootJson, int low, int high, int assertResult)
        {
            var rootArray = JsonSerializer.Deserialize<int?[]>(rootJson);
            var root = TreeNode.Create(rootArray);
            var solution = new Solution();
            var result = solution.RangeSumBST(root, low, high);
            result.Should().Be(assertResult);
        }
    }
}
