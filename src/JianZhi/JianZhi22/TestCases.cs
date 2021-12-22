using FluentAssertions;
using Xunit;

namespace JianZhi22
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var solution = new Solution();
            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };

            // Act
            var result = solution.GetKthFromEnd(head, 2);

            // Assert
            result.val.Should().Be(4);
            result.next.val.Should().Be(5);
        }
    }
}
