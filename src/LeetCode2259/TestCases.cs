using FluentAssertions;
using Xunit;

namespace LeetCode2259
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.RemoveDigit("123", '3');
            result.Should().Be("12");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.RemoveDigit("1231", '1');
            result.Should().Be("231");
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.RemoveDigit("551", '5');
            result.Should().Be("51");
        }

        [Fact]
        public void Test4()
        {
            var solution = new Solution();
            var result = solution.RemoveDigit("2998589353917872714814599237991174513476623756395992135212546127959342974628712329595771672911914471", '3');
            result.Should().Be("299858953917872714814599237991174513476623756395992135212546127959342974628712329595771672911914471");
        }
    }
}
