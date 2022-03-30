using FluentAssertions;
using Xunit;

namespace LeetCode2138
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.DivideString("abcdefghi", 3, 'x');
            result.Should().Equal("abc", "def", "ghi");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.DivideString("abcdefghij", 3, 'x');
            result.Should().Equal("abc", "def", "ghi", "jxx");
        }
    }
}
