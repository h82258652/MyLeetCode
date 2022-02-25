using FluentAssertions;
using Xunit;

namespace LeetCode537
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.ComplexNumberMultiply("1+1i", "1+1i");
            result.Should().Be("0+2i");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.ComplexNumberMultiply("1+-1i", "1+-1i");
            result.Should().Be("0+-2i");
        }
    }
}
