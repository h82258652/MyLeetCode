using FluentAssertions;
using Xunit;

namespace LeetCode2243
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.DigitSum("11111222223", 3);
            result.Should().Be("135");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.DigitSum("00000000", 3);
            result.Should().Be("000");
        }
    }
}
