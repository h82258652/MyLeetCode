using FluentAssertions;
using Xunit;

namespace JianZhi50
{
    public class TestCases
    {
        [Theory]
        [InlineData("abaccdeff", 'b')]
        [InlineData("", ' ')]
        public void Test(string s, char excepted)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var uniqChar = solution.FirstUniqChar(s);

            // Assert
            uniqChar.Should().Be(excepted);
        }
    }
}
