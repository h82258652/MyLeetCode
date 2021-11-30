using System;
using FluentAssertions;
using Xunit;

namespace LeetCode019
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 1, 2, 3, 5 })]
        [InlineData(new[] { 1 }, 1, new int[] { })]
        [InlineData(new[] { 1, 2 }, 1, new[] { 1 })]
        [InlineData(new[] { 1, 2 }, 2, new[] { 2 })]
        public void Test(int[] headArray, int n, int[] assertResult)
        {
            var head = ListNode.Create(headArray);
            var solution = new Solution();
            var result = solution.RemoveNthFromEnd(head, n);
            (result?.ToArray() ?? Array.Empty<int>()).Should().Equal(assertResult);
        }
    }
}
