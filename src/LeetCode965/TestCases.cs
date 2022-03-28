using FluentAssertions;
using Xunit;

namespace LeetCode965
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(1, new TreeNode(1, new TreeNode(1), new TreeNode(1)), new TreeNode(1, right: new TreeNode(1)));
            var result = solution.IsUnivalTree(root);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(2, new TreeNode(2, new TreeNode(5), new TreeNode(2)), new TreeNode(2));
            var result = solution.IsUnivalTree(root);
            result.Should().BeFalse();
        }
    }
}
