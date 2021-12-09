using FluentAssertions;
using Xunit;

namespace LeetCode794
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { "O  ", "   ", "   " }, false)]
        [InlineData(new[] { "XOX", " X ", "   " }, false)]
        [InlineData(new[] { "XXX", "   ", "OOO" }, false)]
        [InlineData(new[] { "XOX", "O O", "XOX" }, true)]
        [InlineData(new[] { "XXX", "XOO", "OO " }, false)]
        [InlineData(new[] { "OXX", "XOX", "OXO" }, false)]
        public void Test(string[] board, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.ValidTicTacToe(board);
            result.Should().Be(assertResult);
        }
    }
}
