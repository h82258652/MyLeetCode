using FluentAssertions;
using Xunit;

namespace LeetCode744
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 'c', 'f', 'j' }, 'a', 'c')]
        [InlineData(new[] { 'c', 'f', 'j' }, 'c', 'f')]
        [InlineData(new[] { 'c', 'f', 'j' }, 'd', 'f')]
        public void Test(char[] letters, char target, char expected)
        {
            var solution = new Solution();
            var result = solution.NextGreatestLetter(letters, target);
            result.Should().Be(expected);
        }
    }
}
