using FluentAssertions;
using Xunit;

namespace LeetCode2224
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.ConvertTime("02:30", "04:35");
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.ConvertTime("11:00", "11:01");
            result.Should().Be(1);
        }
    }
}
