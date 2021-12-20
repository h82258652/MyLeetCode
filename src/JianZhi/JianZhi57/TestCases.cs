using FluentAssertions;
using Xunit;

namespace JianZhi57
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 2, 7 })]
        [InlineData(new[] { 10, 26, 30, 31, 47, 60 }, 40, new[] { 10, 30 })]
        public void Test(int[] nums, int target, int[] expectation)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.TwoSum(nums, target);

            // Assert
            result.Should().BeEquivalentTo(expectation);
        }
    }
}
