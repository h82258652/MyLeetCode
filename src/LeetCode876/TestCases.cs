using FluentAssertions;
using Xunit;

namespace LeetCode876
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 3)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 4)]
        public void Test(int[] headArray, int resultNodeVal)
        {
            var head = ListNode.Create(headArray);
            var solution = new Solution();
            var result = solution.MiddleNode(head);
            result.val.Should().Be(resultNodeVal);
        }
    }
}
