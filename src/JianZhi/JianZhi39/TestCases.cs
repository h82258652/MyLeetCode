using FluentAssertions;
using Xunit;

namespace JianZhi39
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 2, 2, 2, 5, 4, 2 }, 2)]
        public void Test(int[] nums, int excepted)
        {
            // Solution
            var solution = new Solution();

            // Act
            var majority = solution.MajorityElement(nums);

            // Assert
            majority.Should().Be(excepted);
        }
    }
}
