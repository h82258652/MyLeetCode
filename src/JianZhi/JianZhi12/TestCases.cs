using System.Text.Json;
using FluentAssertions;
using Xunit;

namespace JianZhi12
{
    public class TestCases
    {
        [Theory]
        [InlineData(@"[[""A"",""B"",""C"",""E""],
                       [""S"",""F"",""C"",""S""],
                       [""A"",""D"",""E"",""E""]]", "ABCCED", true)]
        [InlineData(@"[[""a"",""b""],
                       [""c"",""d""]]", "abcd", false)]
        public void Test(string boardJson, string word, bool excepted)
        {
            // Arrange
            var board = JsonSerializer.Deserialize<char[][]>(boardJson);
            var solution = new Solution();

            // Act
            var exist = solution.Exist(board, word);

            // Assert
            exist.Should().Be(excepted);
        }
    }
}
