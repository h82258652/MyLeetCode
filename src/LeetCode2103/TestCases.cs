using FluentAssertions;
using Xunit;

namespace LeetCode2103
{
    public class TestCases
    {
        [Theory]
        [InlineData("B0B6G0R6R0R6G9", 1)]
        [InlineData("B0R0G0R9R0B0G0", 1)]
        [InlineData("G4", 0)]
        public void Test(string rings, int expected)
        {
            var solution = new Solution();
            var result = solution.CountPoints(rings);
            result.Should().Be(expected);
        }
    }
}
