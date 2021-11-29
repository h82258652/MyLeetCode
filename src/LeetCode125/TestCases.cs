using FluentAssertions;
using Xunit;

namespace LeetCode125
{
    public class TestCases
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        public void Test(string s, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.IsPalindrome(s);
            result.Should().Be(assertResult);
        }
    }
}
