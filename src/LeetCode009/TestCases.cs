using FluentAssertions;
using Xunit;

namespace LeetCode009
{
    public class TestCases
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(-101, false)]
        public void Test(int x, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.IsPalindrome(x);
            result.Should().Be(assertResult);
        }
    }
}
