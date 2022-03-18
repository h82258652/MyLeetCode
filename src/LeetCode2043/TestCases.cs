using FluentAssertions;
using Xunit;

namespace LeetCode2043
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var bank = new Bank(new long[] { 10, 100, 20, 50, 30 });
            bank.Withdraw(3, 10).Should().BeTrue();
            bank.Transfer(5, 1, 20).Should().BeTrue();
            bank.Deposit(5, 20).Should().BeTrue();
            bank.Transfer(3, 4, 15).Should().BeFalse();
            bank.Withdraw(10, 50).Should().BeFalse();
        }
    }
}
