using FluentAssertions;
using Xunit;

namespace LeetCode513
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(2)
            {
                left = new TreeNode(1),
                right = new TreeNode(3)
            };
            var result = solution.FindBottomLeftValue(root);
            result.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                },
                right = new TreeNode(3)
                {
                    left = new TreeNode(5)
                    {
                        left = new TreeNode(7)
                    },
                    right = new TreeNode(6)
                }
            };
            var result = solution.FindBottomLeftValue(root);
            result.Should().Be(7);
        }
    }
}
