using System.Collections.Generic;

namespace LeetCode350
{
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var numCount = new Dictionary<int, int>();
            foreach (var num1 in nums1)
            {
                numCount.TryGetValue(num1, out var count);
                numCount[num1] = count + 1;
            }

            var result = new List<int>();

            foreach (var num2 in nums2)
            {
                numCount.TryGetValue(num2, out var count);
                if (count > 0)
                {
                    result.Add(num2);
                    numCount[num2] = count - 1;
                }
            }

            return result.ToArray();
        }
    }
}
