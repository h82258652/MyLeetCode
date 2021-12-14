using FluentAssertions;
using Xunit;

namespace LeetCode617
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root1 = new TreeNode(1, new TreeNode(3, new TreeNode(5)), new TreeNode(2));
            var root2 = new TreeNode(2, new TreeNode(1, right: new TreeNode(4)), new TreeNode(3, right: new TreeNode(7)));

            var solution = new Solution();
            var result = solution.MergeTrees(root1, root2);
            result.val.Should().Be(3);
            result.left.val.Should().Be(4);
            result.right.val.Should().Be(5);
            result.left.left.val.Should().Be(5);
            result.left.right.val.Should().Be(4);
            result.right.right.val.Should().Be(7);
        }
    }
}
