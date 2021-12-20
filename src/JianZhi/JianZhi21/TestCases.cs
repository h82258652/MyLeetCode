using FluentAssertions;
using Xunit;

namespace JianZhi21
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 })]
        public void Test(int[] nums)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.Exchange(nums);

            // Assert
            for (var i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length / 2)
                {
                    result[i].Should().Match(temp => temp % 2 == 1);
                }
                else if (i > nums.Length / 2)
                {
                    result[i].Should().Match(temp => temp % 2 == 0);
                }
            }
        }
    }
}
