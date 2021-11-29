using FluentAssertions;
using Xunit;

namespace LeetCode002
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
        [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0 })]
        [InlineData(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void Test(int[] num1, int[] num2, int[] assertResult)
        {
            var l1 = ListNode.Create(num1);
            var l2 = ListNode.Create(num2);
            var solution = new Solution();
            var result = solution.AddTwoNumbers(l1, l2);
            var resultArray = result.ToArray();
            resultArray.Should().Equal(assertResult);
        }
    }
}
