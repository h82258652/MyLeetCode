using System.Collections.Generic;

namespace LeetCode349
{
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var set1 = new HashSet<int>(nums1);
            var set2 = new HashSet<int>(nums2);

            var result = new List<int>();
            foreach (var i in set1)
            {
                if (set2.Contains(i))
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }
    }
}
