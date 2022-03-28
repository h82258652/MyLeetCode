using FluentAssertions;
using Xunit;

namespace LeetCode637
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var result = solution.AverageOfLevels(root);
            result.Should().Equal(3d, 14.5, 11d);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(3, new TreeNode(9, new TreeNode(15), new TreeNode(7)), new TreeNode(20));
            var result = solution.AverageOfLevels(root);
            result.Should().Equal(3d, 14.5, 11d);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var root = new TreeNode(2147483647, new TreeNode(2147483647), new TreeNode(2147483647));
            var result = solution.AverageOfLevels(root);
            result.Should().Equal(2147483647.0, 2147483647.0);
        }
    }
}
