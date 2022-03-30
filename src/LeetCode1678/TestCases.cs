using FluentAssertions;
using Xunit;

namespace LeetCode1678
{
    public class TestCases
    {
        [Theory]
        [InlineData("G()(al)", "Goal")]
        [InlineData("G()()()()(al)", "Gooooal")]
        [InlineData("(al)G(al)()()G", "alGalooG")]
        public void Test(string command, string expected)
        {
            var solution = new Solution();
            var result = solution.Interpret(command);
            result.Should().Be(expected);
        }
    }
}
