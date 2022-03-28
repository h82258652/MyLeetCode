using FluentAssertions;
using Xunit;

namespace LeetCode1022
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(1, new TreeNode(0, new TreeNode(0), new TreeNode(1)), new TreeNode(1, new TreeNode(0), new TreeNode(1)));
            var result = solution.SumRootToLeaf(root);
            result.Should().Be(22);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(0);
            var result = solution.SumRootToLeaf(root);
            result.Should().Be(0);
        }
    }
}
