using FluentAssertions;
using Xunit;

namespace LeetCode205
{
    public class TestCases
    {
        [Theory]
        [InlineData("egg", "add", true)]
        [InlineData("foo", "bar", false)]
        [InlineData("paper", "title", true)]
        [InlineData("badc", "baba", false)]
        public void Test(string s, string t, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.IsIsomorphic(s, t);
            result.Should().Be(assertResult);
        }
    }
}
