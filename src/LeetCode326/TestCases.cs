using FluentAssertions;
using Xunit;

namespace LeetCode326
{
    public class TestCases
    {
        [Theory]
        [InlineData(27, true)]
        [InlineData(0, false)]
        [InlineData(9, true)]
        [InlineData(45, false)]
        public void Test(int n, bool excepted)
        {
            var solution = new Solution();
            var result = solution.IsPowerOfThree(n);
            result.Should().Be(excepted);
        }
    }
}
