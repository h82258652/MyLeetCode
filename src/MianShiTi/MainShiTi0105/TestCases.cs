using FluentAssertions;
using Xunit;

namespace MainShiTi0105
{
    public class TestCases
    {
        [Theory]
        [InlineData("pale", "ple", true)]
        [InlineData("pales", "pal", false)]
        [InlineData("teacher", "bleacher", false)]
        public void Test(string first, string second, bool expected)
        {
            var solution = new Solution();
            var result = solution.OneEditAway(first, second);
            result.Should().Be(expected);
        }
    }
}
