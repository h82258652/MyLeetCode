using System;
using FluentAssertions;
using Xunit;

namespace LeetCode203
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 6, 3, 4, 5, 6 }, 6, new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { }, 1, new int[] { })]
        [InlineData(new[] { 7, 7, 7, 7 }, 7, new int[] { })]
        [InlineData(new[] { 1, 2, 2, 1 }, 2, new[] { 1, 1 })]
        public void Test(int[] headArray, int val, int[] assertResultArray)
        {
            var head = ListNode.Create(headArray);
            var solution = new Solution();
            var result = solution.RemoveElements(head, val);
            (result?.ToArray() ?? Array.Empty<int>()).Should().Equal(assertResultArray);
        }
    }
}
