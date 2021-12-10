using FluentAssertions;
using Xunit;

namespace LeetCode844
{
    public class TestCases
    {
        [Theory]
        [InlineData("ab#c", "ad#c", true)]
        [InlineData("ab##", "c#d#", true)]
        [InlineData("a##c", "#a#c", true)]
        [InlineData("a#c", "b", false)]
        public void Test(string s, string t, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.BackspaceCompare(s, t);
            result.Should().Be(assertResult);
        }
    }
}
