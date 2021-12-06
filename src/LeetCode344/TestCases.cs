using FluentAssertions;
using Xunit;

namespace LeetCode344
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 'h', 'e', 'l', 'l', 'o' }, new[] { 'o', 'l', 'l', 'e', 'h' })]
        [InlineData(new[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
        public void Test(char[] s, char[] assertResult)
        {
            var solution = new Solution();
            solution.ReverseString(s);
            s.Should().Equal(assertResult);
        }
    }
}
