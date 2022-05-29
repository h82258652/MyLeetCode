using FluentAssertions;
using Xunit;

namespace LeetCode468
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.ValidIPAddress("172.16.254.1");
            result.Should().Be("IPv4");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.ValidIPAddress("2001:0db8:85a3:0:0:8A2E:0370:7334");
            result.Should().Be("IPv6");
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.ValidIPAddress("256.256.256.256");
            result.Should().Be("Neither");
        }
    }
}
