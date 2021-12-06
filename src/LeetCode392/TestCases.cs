using FluentAssertions;
using Xunit;

namespace LeetCode392
{
    public class TestCases
    {
        [Theory]
        [InlineData("abc", "ahbgdc", true)]
        [InlineData("axc", "ahbgdc", false)]
        public void Test(string s, string t, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.IsSubsequence(s, t);
            result.Should().Be(assertResult);
        }
    }
}
