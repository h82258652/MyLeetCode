using System.Collections.Generic;
using System.Linq;

namespace LeetCode2248
{
    public class Solution
    {
        public IList<int> Intersection(int[][] nums)
        {
            IEnumerable<int> array = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                array = array.Intersect(nums[i]);
            }

            return array.OrderBy(temp => temp).ToList();
        }
    }
}
