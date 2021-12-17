using FluentAssertions;
using Xunit;

namespace JianZhi06
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
                next = new ListNode(3)
                {
                    next = new ListNode(2)
                }
            };

            // Act
            var result = solution.ReversePrint(head);

            // Assert
            result.Should().Equal(2, 3, 1);
        }
    }
}
