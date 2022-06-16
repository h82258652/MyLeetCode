using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode532
{
    public class Solution
    {
        public int FindPairs(int[] nums, int k)
        {
            if (k == 0)
            {
                return nums.GroupBy(temp => temp).Where(temp => temp.Count() > 1).Count();
            }

            Array.Sort(nums);
            var hashSet = new HashSet<int>(nums);
            var result = 0;
            foreach (var num in nums.Distinct())
            {
                if (hashSet.Contains(num + k))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
