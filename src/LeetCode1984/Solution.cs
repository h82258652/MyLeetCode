using System;

namespace LeetCode1984
{
    public class Solution
    {
        public int MinimumDifference(int[] nums, int k)
        {
            if (k == 1)
            {
                return 0;
            }

            Array.Sort(nums);
            var length = nums.Length;
            var min = int.MaxValue;
            for (var i = 0; i + k - 1 < length; i++)
            {
                var low = nums[i];
                var high = nums[i + k - 1];
                min = Math.Min(min, high - low);
            }

            return min;
        }
    }
}
