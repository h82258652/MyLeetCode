using FluentAssertions;
using Xunit;

namespace LeetCode700
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7));
            var solution = new Solution();
            var result = solution.SearchBST(root, 2);
            result.Should().NotBeNull();
            result.val.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7));
            var solution = new Solution();
            var result = solution.SearchBST(root, 5);
            result.Should().BeNull();
        }
    }
}
