using FluentAssertions;
using Xunit;

namespace LeetCode012
{
    public class TestCases
    {
        [Theory]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(9, "IX")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        public void Test(int num, string assertResult)
        {
            var solution = new Solution();
            var result = solution.IntToRoman(num);
            result.Should().Be(assertResult);
        }
    }
}
