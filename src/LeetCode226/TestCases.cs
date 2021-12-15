using FluentAssertions;
using Xunit;

namespace LeetCode226
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));

            var solution = new Solution();
            var result = solution.InvertTree(root);

            result.Should().NotBeNull();
            result.val.Should().Be(4);
            result.left.Should().NotBeNull();
            result.left.val.Should().Be(7);
            result.left.left.Should().NotBeNull();
            result.left.left.val.Should().Be(9);
            result.left.right.Should().NotBeNull();
            result.left.right.val.Should().Be(6);
            result.right.Should().NotBeNull();
            result.right.val.Should().Be(2);
            result.right.left.Should().NotBeNull();
            result.right.left.val.Should().Be(3);
            result.right.right.Should().NotBeNull();
            result.right.right.val.Should().Be(1);
        }
    }
}
