using FluentAssertions;
using Xunit;

namespace JianZhi09
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var obj = new CQueue();
            obj.AppendTail(3);
            obj.DeleteHead().Should().Be(3);
            obj.DeleteHead().Should().Be(-1);
        }

        [Fact]
        public void Test2()
        {
            var obj = new CQueue();
            obj.DeleteHead().Should().Be(-1);
            obj.AppendTail(5);
            obj.AppendTail(2);
            obj.DeleteHead().Should().Be(5);
            obj.DeleteHead().Should().Be(2);
        }
    }
}
