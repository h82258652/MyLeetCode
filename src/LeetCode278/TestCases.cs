using FluentAssertions;
using Xunit;

namespace LeetCode278
{
    public class TestCases
    {
        [Theory]
        [InlineData(5, 4, 4)]
        [InlineData(1, 1, 1)]
        [InlineData(3, 2, 2)]
        public void Test(int n, int bad, int assertResult)
        {
            var solution = VersionControl.New(bad);
            var result = solution.FirstBadVersion(n);
            result.Should().Be(assertResult);
        }
    }
}
