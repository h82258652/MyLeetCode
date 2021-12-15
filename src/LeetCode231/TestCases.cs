using FluentAssertions;
using Xunit;

namespace LeetCode231
{
    public class TestCases
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(16, true)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(5, false)]
        public void Test(int n, bool excepted)
        {
            var solution = new Solution();
            var result = solution.IsPowerOfTwo(n);
            result.Should().Be(excepted);
        }
    }
}
