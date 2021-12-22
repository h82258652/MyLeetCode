using System.Collections.Generic;
using System.Linq;

namespace LeetCode1431
{
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var max = candies.Max();
            return candies.Select(candy => candy + extraCandies >= max).ToList();
        }
    }
}
