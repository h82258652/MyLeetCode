using FluentAssertions;
using Xunit;

namespace LeetCode984
{
    public class TestCases
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(4, 1)]
        public void Test(int a, int b)
        {
            var solution = new Solution();
            var result = solution.StrWithout3a3b(a, b);
            result.Should().NotContainAny("aaa", "bbb");
        }
    }
}
