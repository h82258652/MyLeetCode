using FluentAssertions;
using Xunit;

namespace LeetCode2235
{
    public class TestCases
    {
        [Theory]
        [InlineData(12, 5, 17)]
        [InlineData(-10, 4, -6)]
        public void Test(int num1, int num2, int excepted)
        {
            var solution = new Solution();
            var result = solution.Sum(num1, num2);
            result.Should().Be(excepted);
        }
    }
}
