using FluentAssertions;
using Xunit;

namespace LeetCode693
{
    public class TestCases
    {
        [Theory]
        [InlineData(5, true)]
        [InlineData(7, false)]
        [InlineData(11, false)]
        [InlineData(10, true)]
        [InlineData(3, false)]
        [InlineData(4, false)]
        public void Test(int n, bool excepted)
        {
            Solution solution = new Solution();
            var result = solution.HasAlternatingBits(n);
            result.Should().Be(excepted);
        }
    }
}
