using FluentAssertions;
using Xunit;

namespace LeetCode515
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(5),
                    right = new TreeNode(3)
                },
                right = new TreeNode(2)
                {
                    right = new TreeNode(9)
                }
            };
            var result = solution.LargestValues(root);
            result.Should().Equal(1, 3, 9);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };
            var result = solution.LargestValues(root);
            result.Should().Equal(1, 3);
        }
    }
}
