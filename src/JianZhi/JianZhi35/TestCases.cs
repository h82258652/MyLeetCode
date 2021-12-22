using FluentAssertions;
using Xunit;

namespace JianZhi35
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var solution = new Solution();

            var node7 = new Node(7);
            var node13 = new Node(13);
            var node11 = new Node(11);
            var node10 = new Node(10);
            var node1 = new Node(1);

            node7.next = node13;
            node13.next = node11;
            node11.next = node10;
            node10.next = node1;

            node13.random = node7;
            node11.random = node1;
            node10.random = node11;
            node1.random = node7;

            // Act
            var copyHead = solution.CopyRandomList(node7);

            // Assert
            copyHead.val.Should().Be(7);
            copyHead.next.val.Should().Be(13);
            copyHead.next.next.val.Should().Be(11);
            copyHead.next.next.next.val.Should().Be(10);
            copyHead.next.next.next.next.val.Should().Be(1);
            copyHead.random.Should().BeNull();
            copyHead.next.random.val.Should().Be(7);
            copyHead.next.next.random.val.Should().Be(1);
            copyHead.next.next.next.random.val.Should().Be(11);
            copyHead.next.next.next.next.random.val.Should().Be(7);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var solution = new Solution();
            var node1 = new Node(1);
            var node2 = new Node(2);

            node1.next = node2;

            node2.random = node2;

            // Act
            var copyHead = solution.CopyRandomList(node1);

            // Assert
            copyHead.val.Should().Be(1);
            copyHead.next.val.Should().Be(2);
            copyHead.random.Should().BeNull();
            copyHead.next.random.val.Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            var solution = new Solution();

            var node3_1 = new Node(3);
            var node3_2 = new Node(3);
            var node3_3 = new Node(3);

            node3_1.next = node3_2;
            node3_2.next = node3_3;

            node3_2.random = node3_1;

            // Act
            var copyHead = solution.CopyRandomList(node3_1);

            // Assert
            copyHead.val.Should().Be(3);
            copyHead.next.val.Should().Be(3);
            copyHead.next.next.val.Should().Be(3);
            copyHead.random.Should().BeNull();
            copyHead.next.random.val.Should().Be(3);
            copyHead.next.next.random.Should().BeNull();
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            var solution = new Solution();

            // Act
            var copyHead = solution.CopyRandomList(null);

            // Assert
            copyHead.Should().BeNull();
        }
    }
}
