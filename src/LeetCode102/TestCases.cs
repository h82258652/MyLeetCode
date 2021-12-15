using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace LeetCode102
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var expectation = new List<IList<int>>
            {
                new List<int> { 3 },
                new List<int> { 9, 20 },
                new List<int> { 15, 7 }
            };

            var solution = new Solution();
            var result = solution.LevelOrder(root);
            result.Should().BeEquivalentTo(expectation);
        }
    }
}
