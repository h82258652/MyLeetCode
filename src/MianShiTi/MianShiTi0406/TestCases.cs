using FluentAssertions;
using Xunit;

namespace MianShiTi0406
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var p = new TreeNode(1);
            var expected = new TreeNode(2)
            {
                left = p,
                right = new TreeNode(3)
            };
            var root = expected;
            var result = solution.InorderSuccessor(root, p);
            result.Should().Be(expected);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var p = new TreeNode(6);
            var root = new TreeNode(5)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(2)
                    {
                        left = new TreeNode(1)
                    },
                    right = new TreeNode(4)
                },
                right = p
            };
            var result = solution.InorderSuccessor(root, p);
            result.Should().BeNull();
        }
    }
}
