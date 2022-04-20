using FluentAssertions;
using Xunit;

namespace LeetCode2236
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(10)
            {
                left = new TreeNode(4),
                right = new TreeNode(6)
            };
            var result = solution.CheckTree(root);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(5)
            {
                left = new TreeNode(3),
                right = new TreeNode(1)
            };
            var result = solution.CheckTree(root);
            result.Should().BeFalse();
        }
    }
}
