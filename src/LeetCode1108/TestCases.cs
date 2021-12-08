using FluentAssertions;
using Xunit;

namespace LeetCode1108
{
    public class TestCases
    {
        [Theory]
        [InlineData("1.1.1.1", "1[.]1[.]1[.]1")]
        [InlineData("255.100.50.0", "255[.]100[.]50[.]0")]
        public void Test(string address, string assertResult)
        {
            var solution = new Solution();
            var result = solution.DefangIPaddr(address);
            result.Should().Be(assertResult);
        }
    }
}
