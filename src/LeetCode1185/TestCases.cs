using FluentAssertions;
using Xunit;

namespace LeetCode1185
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.DayOfTheWeek(31, 8, 2019);
            result.Should().Be("Saturday");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.DayOfTheWeek(18, 7, 1999);
            result.Should().Be("Sunday");
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.DayOfTheWeek(15, 8, 1993);
            result.Should().Be("Sunday");
        }
    }
}
