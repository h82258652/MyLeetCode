using FluentAssertions;
using Xunit;

namespace LeetCode374
{
    public class TestCases
    {
        [Theory]
        [InlineData(10, 6, 6)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 1)]
        [InlineData(2, 2, 2)]
        [InlineData(2126753390, 1702766719, 1702766719)]
        public void Test(int n, int pick, int assertResult)
        {
            var solution = GuessGame.New(pick);
            var result = solution.GuessNumber(n);
            result.Should().Be(assertResult);
        }
    }
}
