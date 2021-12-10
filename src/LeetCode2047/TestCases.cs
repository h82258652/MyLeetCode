using FluentAssertions;
using Xunit;

namespace LeetCode2047
{
    public class TestCases
    {
        [Theory]
        [InlineData("cat and  dog", 3)]
        [InlineData("!this  1-s b8d!", 0)]
        [InlineData("alice and  bob are playing stone-game10", 5)]
        [InlineData("he bought 2 pencils, 3 erasers, and 1  pencil-sharpener.", 6)]
        public void Test(string sentence, int expected)
        {
            var solution = new Solution();
            var result = solution.CountValidWords(sentence);
            result.Should().Be(expected);
        }
    }
}
