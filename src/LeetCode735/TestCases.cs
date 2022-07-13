using FluentAssertions;
using Xunit;

namespace LeetCode735
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var asteroids = new int[] { 5, 10, -5 };
            var result = solution.AsteroidCollision(asteroids);
            result.Should().Equal(5, 10);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var asteroids = new int[] { 8, -8 };
            var result = solution.AsteroidCollision(asteroids);
            result.Should().Equal();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var asteroids = new int[] { 10, 2, -5 };
            var result = solution.AsteroidCollision(asteroids);
            result.Should().Equal(10);
        }

        [Fact]
        public void Test4()
        {
            var solution = new Solution();
            var asteroids = new int[] { 7, -1, 2, -3, -6, -6, -6, 4, 10, 2 };
            var result = solution.AsteroidCollision(asteroids);
            result.Should().Equal(7, 4, 10, 2);
        }
    }
}
