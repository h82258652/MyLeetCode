using FluentAssertions;
using Xunit;

namespace LeetCode2086
{
    public class TestCases
    {
        [Theory]
        [InlineData("H..H", 2)]
        [InlineData(".H.H.", 1)]
        [InlineData(".HHH.", -1)]
        [InlineData("H", -1)]
        [InlineData(".", 0)]
        public void Test(string street, int assertResult)
        {
            var solution = new Solution();
            var result = solution.MinimumBuckets(street);
            result.Should().Be(assertResult);
        }
    }
}
