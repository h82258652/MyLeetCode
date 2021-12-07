using FluentAssertions;
using Xunit;

namespace LeetCode111
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var solution = new Solution();
            var result = solution.MinDepth(root);
            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var root = new TreeNode(2, right: new TreeNode(3, right: new TreeNode(4, right: new TreeNode(5, right: new TreeNode(6)))));
            var solution = new Solution();
            var result = solution.MinDepth(root);
            result.Should().Be(5);
        }
    }
}
