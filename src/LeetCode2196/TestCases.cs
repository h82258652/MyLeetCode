using FluentAssertions;
using Xunit;

namespace LeetCode2196
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var descriptions = new[]
            {
                new[] { 20, 15, 1 },
                new[] { 20, 17, 0 },
                new[] { 50, 20, 1 },
                new[] { 50, 80, 0 },
                new[] { 80, 19, 1 }
            };
            var result = solution.CreateBinaryTree(descriptions);
            result.val.Should().Be(50);
            result.left.val.Should().Be(20);
            result.left.left.val.Should().Be(15);
            result.left.right.val.Should().Be(17);
            result.right.val.Should().Be(80);
            result.right.left.val.Should().Be(19);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var descriptions = new[]
            {
                new[] { 1, 2, 1 },
                new[] { 2, 3, 0 },
                new[] { 3, 4, 1 }
            };
            var result = solution.CreateBinaryTree(descriptions);
            result.val.Should().Be(1);
            result.left.val.Should().Be(2);
            result.left.right.val.Should().Be(3);
            result.left.right.left.val.Should().Be(4);
        }
    }
}
