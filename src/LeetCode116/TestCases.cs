using FluentAssertions;
using Xunit;

namespace LeetCode116
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var root = new Node(1)
            {
                left = new Node(2)
                {
                    left = new Node(4),
                    right = new Node(5)
                },
                right = new Node(3)
                {
                    left = new Node(6),
                    right = new Node(7)
                }
            };

            var solution = new Solution();
            var result = solution.Connect(root);
            result.val.Should().Be(1);
            result.next.Should().BeNull();

            result.left.val.Should().Be(2);
            result.left.next.Should().NotBeNull();
            result.left.next.val.Should().Be(3);
            result.left.next.next.Should().BeNull();

            result.left.left.val.Should().Be(4);
            result.left.left.next.Should().NotBeNull();
            result.left.left.next.val.Should().Be(5);
            result.left.left.next.next.Should().NotBeNull();
            result.left.left.next.next.val.Should().Be(6);
            result.left.left.next.next.next.Should().NotBeNull();
            result.left.left.next.next.next.val.Should().Be(7);
            result.left.left.next.next.next.next.Should().BeNull();
        }
    }
}
