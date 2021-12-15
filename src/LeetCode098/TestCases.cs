using FluentAssertions;
using Xunit;

namespace LeetCode098
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(2,
                new TreeNode(1),
                new TreeNode(3));

            var solution = new Solution();
            var result = solution.IsValidBST(root);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var root = new TreeNode(5,
                new TreeNode(1),
                new TreeNode(4,
                    new TreeNode(3),
                    new TreeNode(6)));

            var solution = new Solution();
            var result = solution.IsValidBST(root);
            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var root = new TreeNode(5,
                new TreeNode(4),
                new TreeNode(6,
                    new TreeNode(3),
                    new TreeNode(7)));

            var solution = new Solution();
            var result = solution.IsValidBST(root);
            result.Should().BeFalse();
        }

        [Fact]
        public void Test4()
        {
            var root = new TreeNode(-2147483648,
                right: new TreeNode(2147483647));

            var solution = new Solution();
            var result = solution.IsValidBST(root);
            result.Should().BeTrue();
        }
    }
}
