using System;
using FluentAssertions;
using Xunit;

namespace LeetCode021
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { }, new[] { 0 }, new[] { 0 })]
        public void Test(int[] list1Array, int[] list2Array, int[] assertResultArray)
        {
            var list1 = ListNode.Create(list1Array);
            var list2 = ListNode.Create(list2Array);
            var solution = new Solution();
            var result = solution.MergeTwoLists(list1, list2);
            (result?.ToArray() ?? Array.Empty<int>()).Should().Equal(assertResultArray);
        }
    }
}
