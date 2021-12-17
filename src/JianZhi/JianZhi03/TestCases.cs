using FluentAssertions;
using Xunit;

namespace JianZhi03
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 2, 3, 1, 0, 2, 5, 3 }, new[] { 2, 3 })]
        public void Test(int[] nums, int[] validValues)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var repeatNumber = solution.FindRepeatNumber(nums);

            // Assert
            repeatNumber.Should().BeOneOf(validValues);
        }
    }
}
