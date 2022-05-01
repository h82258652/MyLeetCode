using FluentAssertions;
using Xunit;

namespace LeetCode1305
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root1 = new TreeNode(2)
            {
                left = new TreeNode(1),
                right = new TreeNode(4)
            };
            var root2 = new TreeNode(1)
            {
                left = new TreeNode(0),
                right = new TreeNode(3)
            };
            var result = solution.GetAllElements(root1, root2);
            result.Should().Equal(0, 1, 1, 2, 3, 4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root1 = new TreeNode(1)
            {
                right = new TreeNode(8)
            };
            var root2 = new TreeNode(8)
            {
                left = new TreeNode(1)
            };
            var result = solution.GetAllElements(root1, root2);
            result.Should().Equal(1, 1, 8, 8);
        }
    }
}
