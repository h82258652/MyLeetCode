using FluentAssertions;
using Xunit;

namespace LeetCode897
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(5)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(2)
                    {
                        left = new TreeNode(1)
                    },
                    right = new TreeNode(4)
                },
                right = new TreeNode(6)
                {
                    right = new TreeNode(8)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(9)
                    }
                }
            };
            var result = solution.IncreasingBST(root);
            result.val.Should().Be(1);
            result.left.Should().BeNull();
            result.right.val.Should().Be(2);
            result.right.left.Should().BeNull();
            result.right.right.val.Should().Be(3);
            result.right.right.left.Should().BeNull();
            result.right.right.right.val.Should().Be(4);
            result.right.right.right.left.Should().BeNull();
            result.right.right.right.right.val.Should().Be(5);
            result.right.right.right.right.left.Should().BeNull();
            result.right.right.right.right.right.val.Should().Be(6);
            result.right.right.right.right.right.left.Should().BeNull();
            result.right.right.right.right.right.right.val.Should().Be(7);
            result.right.right.right.right.right.right.left.Should().BeNull();
            result.right.right.right.right.right.right.right.val.Should().Be(8);
            result.right.right.right.right.right.right.right.left.Should().BeNull();
            result.right.right.right.right.right.right.right.right.val.Should().Be(9);
            result.right.right.right.right.right.right.right.right.left.Should().BeNull();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(5)
            {
                left = new TreeNode(1),
                right = new TreeNode(7)
            };
            var result = solution.IncreasingBST(root);
            result.val.Should().Be(1);
            result.left.Should().BeNull();
            result.right.val.Should().Be(5);
            result.right.left.Should().BeNull();
            result.right.right.val.Should().Be(7);
            result.right.right.left.Should().BeNull();
        }
    }
}
