using FluentAssertions;
using Xunit;

namespace LeetCode654
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new[] { 3, 2, 1, 6, 0, 5 };
            var result = solution.ConstructMaximumBinaryTree(nums);
            result.val.Should().Be(6);
            result.left.val.Should().Be(3);
            result.left.right.val.Should().Be(2);
            result.left.right.right.val.Should().Be(1);
            result.right.val.Should().Be(5);
            result.right.left.val.Should().Be(0);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new[] { 3, 2, 1 };
            var result = solution.ConstructMaximumBinaryTree(nums);
            result.val.Should().Be(3);
            result.right.val.Should().Be(2);
            result.right.right.val.Should().Be(1);
        }
    }
}
