using FluentAssertions;
using Xunit;

namespace LeetCode1844
{
    public class TestCases
    {
        [Theory]
        [InlineData("a1c1e1", "abcdef")]
        [InlineData("a1b2c3d4e", "abbdcfdhe")]
        public void Test(string s, string excepted)
        {
            var solution = new Solution();
            var result = solution.ReplaceDigits(s);
            result.Should().Be(excepted);
        }
    }
}
