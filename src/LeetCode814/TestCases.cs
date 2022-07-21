using FluentAssertions;
using Xunit;

namespace LeetCode814
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(1)
            {
                right = new TreeNode(0)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(1)
                }
            };
            var solution = new Solution();
            var result = solution.PruneTree(root);
            result.val.Should().Be(1);
            result.right.val.Should().Be(0);
            result.right.left.Should().BeNull();
            result.right.right.val.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var root = new TreeNode(1)
            {
                left = new TreeNode(0)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(0)
                },
                right = new TreeNode(1)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(1)
                }
            };
            var solution = new Solution();
            var result = solution.PruneTree(root);
            result.val.Should().Be(1);
            result.left.Should().BeNull();
            result.right.val.Should().Be(1);
            result.right.left.Should().BeNull();
            result.right.right.val.Should().Be(1);
        }

        [Fact]
        public void Test3()
        {
            var root = new TreeNode(1)
            {
                left = new TreeNode(1)
                {
                    left = new TreeNode(1)
                    {
                        left = new TreeNode(0)
                    },
                    right = new TreeNode(1)
                },
                right = new TreeNode(0)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(1)
                }
            };
            var solution = new Solution();
            var result = solution.PruneTree(root);
            result.val.Should().Be(1);
            result.left.val.Should().Be(1);
            result.left.left.val.Should().Be(1);
            result.left.right.val.Should().Be(1);
            result.left.left.left.Should().BeNull();
            result.right.val.Should().Be(0);
            result.right.left.Should().BeNull();
            result.right.right.val.Should().Be(1);
        }
    }
}
