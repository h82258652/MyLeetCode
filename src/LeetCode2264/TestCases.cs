using FluentAssertions;
using Xunit;

namespace LeetCode2264
{
    public class TestCases
    {
        [Theory]
        [InlineData("6777133339", "777")]
        [InlineData("2300019", "000")]
        [InlineData("42352338", "")]
        [InlineData("222", "222")]
        public void Test(string num, string expected)
        {
            var solution = new Solution();
            var result = solution.LargestGoodInteger(num);
            result.Should().Be(expected);
        }
    }
}
