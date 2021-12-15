using FluentAssertions;
using Xunit;

namespace LeetCode112
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(5,
                new TreeNode(4,
                    new TreeNode(11,
                        new TreeNode(7),
                        new TreeNode(2))),
                new TreeNode(8,
                    new TreeNode(13),
                    new TreeNode(4,
                        right: new TreeNode(1))));

            var solution = new Solution();
            var result = solution.HasPathSum(root, 22);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var root = new TreeNode(1,
                new TreeNode(2),
                new TreeNode(3));

            var solution = new Solution();
            var result = solution.HasPathSum(root, 5);
            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.HasPathSum(null, 0);
            result.Should().BeFalse();
        }
    }
}
