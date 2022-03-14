using FluentAssertions;
using Xunit;

namespace LeetCode599
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var list1 = new[] { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            var list2 = new[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" };
            var result = solution.FindRestaurant(list1, list2);
            result.Should().Equal("Shogun");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var list1 = new[] { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            var list2 = new[] { "KFC", "Shogun", "Burger King" };
            var result = solution.FindRestaurant(list1, list2);
            result.Should().Equal("Shogun");
        }
    }
}
