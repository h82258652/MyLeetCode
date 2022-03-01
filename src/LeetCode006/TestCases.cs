using FluentAssertions;
using Xunit;

namespace LeetCode006
{
    public class TestCases
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]
        [InlineData("AB", 1, "AB")]
        public void Test(string s, int numRows, string excepted)
        {
            var solution = new Solution();
            var result = solution.Convert(s, numRows);
            result.Should().Be(excepted);
        }
    }
}
