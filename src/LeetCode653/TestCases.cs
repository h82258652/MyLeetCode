using FluentAssertions;
using Xunit;

namespace LeetCode653
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(5,
                new TreeNode(3,
                    new TreeNode(2),
                    new TreeNode(4)),
                new TreeNode(6,
                    right: new TreeNode(7)));

            var solution = new Solution();
            var result = solution.FindTarget(root, 9);
            result.Should().BeTrue();
        }
    }
}
