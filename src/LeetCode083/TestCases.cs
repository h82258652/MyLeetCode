using System;
using FluentAssertions;
using Xunit;

namespace LeetCode083
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 1, 2 }, new[] { 1, 2 })]
        [InlineData(new[] { 1, 1, 2, 3, 3 }, new[] { 1, 2, 3 })]
        public void Test(int[] headArray, int[] assertResult)
        {
            var head = ListNode.Create(headArray);
            var solution = new Solution();
            var result = solution.DeleteDuplicates(head);
            (result?.ToArray() ?? Array.Empty<int>()).Should().Equal(assertResult);
        }
    }
}
