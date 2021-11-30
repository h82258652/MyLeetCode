using FluentAssertions;
using Xunit;

namespace LeetCode088
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new[] { 1 }, 1, new int[] { }, 0, new[] { 1 })]
        [InlineData(new[] { 0 }, 0, new[] { 1 }, 1, new[] { 1 })]
        [InlineData(new[] { 4, 5, 6, 0, 0, 0 }, 3, new[] { 1, 2, 3 }, 3, new[] { 1, 2, 3, 4, 5, 6 })]
        public void Test(int[] nums1, int m, int[] nums2, int n, int[] assertResult)
        {
            var solution = new Solution();
            solution.Merge(nums1, m, nums2, n);
            nums1.Should().Equal(assertResult);
        }
    }
}
