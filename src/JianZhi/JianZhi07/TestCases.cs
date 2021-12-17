using FluentAssertions;
using Xunit;

namespace JianZhi07
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var solution = new Solution();
            var preorder = new[] { 3, 9, 20, 15, 7 };
            var inorder = new[] { 9, 3, 15, 20, 7 };

            // Act
            var root = solution.BuildTree(preorder, inorder);

            // Assert
            root.Should().NotBeNull();
            root.val.Should().Be(3);
            root.left.Should().NotBeNull();
            root.left.val.Should().Be(9);
            root.right.Should().NotBeNull();
            root.right.val.Should().Be(20);
            root.right.left.Should().NotBeNull();
            root.right.left.val.Should().Be(15);
            root.right.right.Should().NotBeNull();
            root.right.right.val.Should().Be(7);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var solution = new Solution();
            var preorder = new[] { -1 };
            var inorder = new[] { -1 };

            // Act
            var root = solution.BuildTree(preorder, inorder);

            // Assert
            root.Should().NotBeNull();
            root.val.Should().Be(-1);
        }
    }
}
