using FluentAssertions;
using Xunit;

namespace JianZhi05
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var solution = new Solution();
            const string s = "We are happy.";

            // Act
            var result = solution.ReplaceSpace(s);

            // Assert
            result.Should().Be("We%20are%20happy.");
        }
    }
}
