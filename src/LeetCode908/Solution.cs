using System;

namespace LeetCode908
{
    public class Solution
    {
        public int SmallestRangeI(int[] nums, int k)
        {
            var max = int.MinValue;
            var min = int.MaxValue;
            foreach (var num in nums)
            {
                max = Math.Max(max, num);
                min = Math.Min(min, num);
            }

            max -= k;
            min += k;

            if (max <= min)
            {
                return 0;
            }
            else
            {
                return max - min;
            }
        }
    }
}
