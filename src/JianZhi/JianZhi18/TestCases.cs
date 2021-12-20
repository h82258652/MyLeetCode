using FluentAssertions;
using Xunit;

namespace JianZhi18
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var solution = new Solution();
            var head = new ListNode(4)
            {
                next = new ListNode(5)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(9)
                    }
                }
            };

            // Act
            var newHead = solution.DeleteNode(head, 5);

            // Assert
            newHead.val.Should().Be(4);
            newHead.next.val.Should().Be(1);
            newHead.next.next.val.Should().Be(9);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var solution = new Solution();
            var head = new ListNode(4)
            {
                next = new ListNode(5)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(9)
                    }
                }
            };

            // Act
            var newHead = solution.DeleteNode(head, 1);

            // Assert
            newHead.val.Should().Be(4);
            newHead.next.val.Should().Be(5);
            newHead.next.next.val.Should().Be(9);
        }
    }
}
