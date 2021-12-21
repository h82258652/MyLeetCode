using FluentAssertions;
using Xunit;

namespace JianZhi55I
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var solution = new Solution();
            var root = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };

            // Act
            var maxDepth = solution.MaxDepth(root);

            // Assert
            maxDepth.Should().Be(3);
        }
    }
}
