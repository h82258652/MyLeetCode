using FluentAssertions;
using Xunit;

namespace LeetCode350
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 2, 1 }, new[] { 2, 2 }, new[] { 2, 2 })]
        [InlineData(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 }, new[] { 4, 9 })]
        public void Test(int[] nums1, int[] nums2, int[] assertResult)
        {
            var solution = new Solution();
            var result = solution.Intersect(nums1, nums2);
            result.Should().BeEquivalentTo(assertResult);
        }
    }
}
