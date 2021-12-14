using FluentAssertions;
using Xunit;

namespace LeetCode557
{
    public class TestCases
    {
        [Theory]
        [InlineData("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
        public void Test(string s, string excepted)
        {
            var solution = new Solution();
            var result = solution.ReverseWords(s);
            result.Should().Be(excepted);
        }
    }
}
