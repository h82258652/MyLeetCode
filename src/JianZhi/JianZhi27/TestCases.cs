using System;
using FluentAssertions;
using Xunit;

namespace JianZhi27
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var solution = new Solution();
            var root = new TreeNode(4)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(3)
                },
                right = new TreeNode(7)
                {
                    left = new TreeNode(6),
                    right = new TreeNode(9)
                }
            };

            // Act
            var mirrorRoot = solution.MirrorTree(root);

            // Assert
            mirrorRoot.val.Should().Be(4);
            mirrorRoot.left.val.Should().Be(7);
            mirrorRoot.right.val.Should().Be(2);
            mirrorRoot.left.left.val.Should().Be(9);
            mirrorRoot.left.right.val.Should().Be(6);
            mirrorRoot.right.left.val.Should().Be(3);
            mirrorRoot.right.right.val.Should().Be(1);
        }
    }
}
