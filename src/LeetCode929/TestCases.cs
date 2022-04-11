using FluentAssertions;
using Xunit;

namespace LeetCode929
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var emails = new[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            var result = solution.NumUniqueEmails(emails);
            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var emails = new[] { "a@leetcode.com", "b@leetcode.com", "c@leetcode.com" };
            var result = solution.NumUniqueEmails(emails);
            result.Should().Be(3);
        }
    }
}
