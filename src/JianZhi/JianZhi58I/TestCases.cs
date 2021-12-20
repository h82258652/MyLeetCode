using FluentAssertions;
using Xunit;

namespace JianZhi58I
{
    public class TestCases
    {
        [Theory]
        [InlineData("the sky is blue", "blue is sky the")]
        [InlineData("  hello world!  ", "world! hello")]
        [InlineData("a good   example", "example good a")]
        public void Test(string s, string expected)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.ReverseWords(s);

            // Assert
            result.Should().Be(expected);
        }
    }
}
