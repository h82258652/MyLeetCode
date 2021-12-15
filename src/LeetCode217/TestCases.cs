using FluentAssertions;
using Xunit;

namespace LeetCode217
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 1 }, true)]
        [InlineData(new[] { 1, 2, 3, 4 }, false)]
        [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void Test(int[] nums, bool excepted)
        {
            var solution = new Solution();
            var result = solution.ContainsDuplicate(nums);
            result.Should().Be(excepted);
        }
    }
}
