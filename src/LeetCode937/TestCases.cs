using FluentAssertions;
using Xunit;

namespace LeetCode937
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var logs = new string[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            var result = solution.ReorderLogFiles(logs);
            result.Should().Equal("let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var logs = new string[] { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo" };
            var result = solution.ReorderLogFiles(logs);
            result.Should().Equal("g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7");
        }
    }
}
