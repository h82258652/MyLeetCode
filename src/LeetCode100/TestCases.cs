using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace LeetCode100
{
    public class TestCases
    {
        [Theory]
        [InlineData("[1,2,3]", "[1,2,3]", true)]
        [InlineData("[1,2]", "[1,null,2]", false)]
        [InlineData("[1,2,1]", "[1,1,2]", false)]
        public void Test(string pJson, string qJson, bool assertResult)
        {
            var pArray = JsonSerializer.Deserialize<int?[]>(pJson);
            var qArray = JsonSerializer.Deserialize<int?[]>(qJson);
            var p = TreeNode.Create(pArray);
            var q = TreeNode.Create(qArray);
            var solution = new Solution();
            var result = solution.IsSameTree(p, q);
            result.Should().Be(assertResult);
        }
    }
}
