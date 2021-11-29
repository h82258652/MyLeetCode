using FluentAssertions;
using Xunit;

namespace LeetCode020
{
    public class TestCases
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        [InlineData("{[]}", true)]
        [InlineData("[", false)]
        public void Test(string s, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.IsValid(s);
            result.Should().Be(assertResult);
        }
    }
}
