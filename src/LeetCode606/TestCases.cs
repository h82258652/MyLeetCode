using FluentAssertions;
using Xunit;

namespace LeetCode606
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
                    left = new TreeNode(4)
                },
                right = new TreeNode(3)
            };
            var result = solution.Tree2str(root);
            result.Should().Be("1(2(4))(3)");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    right = new TreeNode(4)
                },
                right = new TreeNode(3)
            };
            var result = solution.Tree2str(root);
            result.Should().Be("1(2()(4))(3)");
        }
    }
}
