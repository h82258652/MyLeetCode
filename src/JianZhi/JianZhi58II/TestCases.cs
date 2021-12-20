using FluentAssertions;
using Xunit;

namespace JianZhi58II
{
    public class TestCases
    {
        [Theory]
        [InlineData("abcdefg", 2, "cdefgab")]
        [InlineData("lrloseumgh", 6, "umghlrlose")]
        public void Test(string s, int n, string excepted)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.ReverseLeftWords(s, n);

            // Assert
            result.Should().Be(excepted);
        }
    }
}
