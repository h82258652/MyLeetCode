using FluentAssertions;
using Xunit;

namespace LeetCode404
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var solution = new Solution();
            var result = solution.SumOfLeftLeaves(root);
            result.Should().Be(24);
        }

        [Fact]
        public void Test2()
        {
            var root = new TreeNode(1);
            var solution = new Solution();
            var result = solution.SumOfLeftLeaves(root);
            result.Should().Be(0);
        }
    }
}
