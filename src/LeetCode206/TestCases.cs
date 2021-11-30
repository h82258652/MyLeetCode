using System;
using FluentAssertions;
using Xunit;

namespace LeetCode206
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
        [InlineData(new[] { 1, 2 }, new[] { 2, 1 })]
        [InlineData(new int[] { }, new int[] { })]
        public void Test(int[] headArray, int[] assertResult)
        {
            var head = ListNode.Create(headArray);
            var solution = new Solution();
            var result = solution.ReverseList(head);
            (result?.ToArray() ?? Array.Empty<int>()).Should().Equal(assertResult);
        }
    }
}
