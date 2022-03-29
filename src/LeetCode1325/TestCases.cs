using FluentAssertions;
using Xunit;

namespace LeetCode1325
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(2)
                },
                right = new TreeNode(3)
                {
                    left = new TreeNode(2),
                    right = new TreeNode(4)
                }
            };
            var target = 2;
            var result = solution.RemoveLeafNodes(root, target);
            result.val.Should().Be(1);
            result.left.Should().BeNull();
            result.right.val.Should().Be(3);
            result.right.left.Should().BeNull();
            result.right.right.val.Should().Be(4);
            result.right.right.left.Should().BeNull();
            result.right.right.right.Should().BeNull();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(2)
                },
                right = new TreeNode(3)
            };
            var target = 3;
            var result = solution.RemoveLeafNodes(root, target);
            result.val.Should().Be(1);
            result.left.val.Should().Be(3);
            result.right.Should().BeNull();
            result.left.left.Should().BeNull();
            result.left.right.val.Should().Be(2);
            result.left.right.left.Should().BeNull();
            result.left.right.right.Should().BeNull();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(2)
                    {
                        left = new TreeNode(2)
                    }
                }
            };
            var target = 2;
            var result = solution.RemoveLeafNodes(root, target);
            result.val.Should().Be(1);
            result.left.Should().BeNull();
            result.right.Should().BeNull();
        }

        [Fact]
        public void Test4()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(1),
                right = new TreeNode(1)
            };
            var target = 1;
            var result = solution.RemoveLeafNodes(root, target);
            result.Should().BeNull();
        }

        [Fact]
        public void Test5()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };
            var target = 1;
            var result = solution.RemoveLeafNodes(root, target);
            result.val.Should().Be(1);
            result.left.val.Should().Be(2);
            result.right.val.Should().Be(3);
        }
    }
}
