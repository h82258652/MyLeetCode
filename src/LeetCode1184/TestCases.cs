using FluentAssertions;
using Xunit;

namespace LeetCode1184
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var distance = new int[] { 1, 2, 3, 4 };
            var start = 0;
            var destination = 1;
            var result = solution.DistanceBetweenBusStops(distance, start, destination);
            result.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var distance = new int[] { 1, 2, 3, 4 };
            var start = 0;
            var destination = 2;
            var result = solution.DistanceBetweenBusStops(distance, start, destination);
            result.Should().Be(3);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var distance = new int[] { 1, 2, 3, 4 };
            var start = 0;
            var destination = 3;
            var result = solution.DistanceBetweenBusStops(distance, start, destination);
            result.Should().Be(4);
        }
    }
}
