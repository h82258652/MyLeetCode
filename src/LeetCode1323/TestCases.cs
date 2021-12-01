using FluentAssertions;
using Xunit;

namespace LeetCode1323
{
    public class TestCases
    {
        [Theory]
        [InlineData(9669, 9969)]
        [InlineData(9996, 9999)]
        [InlineData(9999, 9999)]
        public void Test(int num, int assertResult)
        {
            var solution = new Solution();
            var result = solution.Maximum69Number(num);
            result.Should().Be(assertResult);
        }
    }
}
