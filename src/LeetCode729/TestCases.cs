using FluentAssertions;
using Xunit;

namespace LeetCode729
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var myCalendar = new MyCalendar();
            myCalendar.Book(10, 20).Should().BeTrue();
            myCalendar.Book(15, 25).Should().BeFalse();
            myCalendar.Book(20, 30).Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var myCalendar = new MyCalendar();
            myCalendar.Book(47, 50).Should().BeTrue();
            myCalendar.Book(33, 41).Should().BeTrue();
            myCalendar.Book(39, 45).Should().BeFalse();
            myCalendar.Book(33, 42).Should().BeFalse();
            myCalendar.Book(25, 32).Should().BeTrue();
            myCalendar.Book(26, 35).Should().BeFalse();
            myCalendar.Book(19, 25).Should().BeTrue();
            myCalendar.Book(3, 8).Should().BeTrue();
            myCalendar.Book(8, 13).Should().BeTrue();
            myCalendar.Book(18, 27).Should().BeFalse();
        }
    }
}
