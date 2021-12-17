using FluentAssertions;
using Xunit;

namespace JianZhi10I
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var solution = new Solution();

            // Act
            var fib = solution.Fib(2);

            // Assert
            fib.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var solution = new Solution();

            // Act
            var fib = solution.Fib(5);

            // Assert
            fib.Should().Be(5);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            var solution = new Solution();

            // Act
            var fib = solution.Fib(45);

            // Assert
            fib.Should().Be(134903163);
        }
    }
}
