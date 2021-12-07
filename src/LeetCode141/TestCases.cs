using FluentAssertions;
using Xunit;

namespace LeetCode141
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var node3 = new ListNode(3);
            var node2 = new ListNode(2);
            // ReSharper disable once RedundantArgumentDefaultValue
            var node0 = new ListNode(0);
            var nodeMinus4 = new ListNode(-4);

            node3.next = node2;
            node2.next = node0;
            node0.next = nodeMinus4;
            nodeMinus4.next = node2;

            var solution = new Solution();

            // Act
            var result = solution.HasCycle(node3);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var node1 = new ListNode(1);
            var node2 = new ListNode(2);

            node1.next = node2;
            node2.next = node1;

            var solution = new Solution();

            // Act
            var result = solution.HasCycle(node1);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            var node1 = new ListNode(1);

            var solution = new Solution();

            // Act
            var result = solution.HasCycle(node1);

            // Assert
            result.Should().BeFalse();
        }
    }
}
