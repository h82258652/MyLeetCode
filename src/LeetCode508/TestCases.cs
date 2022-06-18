using FluentAssertions;
using Xunit;

namespace LeetCode508
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var root = new TreeNode(5)
            {
                left = new TreeNode(2),
                right = new TreeNode(-3)
            };
            var result = solution.FindFrequentTreeSum(root);
            result.Should().Equal(2, -3, 4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var root = new TreeNode(5)
            {
                left = new TreeNode(2),
                right = new TreeNode(-5)
            };
            var result = solution.FindFrequentTreeSum(root);
            result.Should().Equal(2);
        }
    }
}
