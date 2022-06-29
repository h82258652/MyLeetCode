using FluentAssertions;
using Xunit;

namespace LeetCode535
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var codec = new Codec();
            var url = "https://leetcode.com/problems/design-tinyurl";
            var tiny = codec.encode(url);
            var ans = codec.decode(tiny);
            ans.Should().Be(url);
        }
    }
}
