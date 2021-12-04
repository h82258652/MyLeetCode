using System;

namespace LeetCode198
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            var length = nums.Length;
            if (length == 1)
            {
                return nums[0];
            }

            if (length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }

            var rob = new int[nums.Length];
            rob[0] = nums[0];
            rob[1] = Math.Max(nums[0], nums[1]);
            rob[2] = Math.Max(nums[0] + nums[2], nums[1]);

            for (var i = 3; i < length; i++)
            {
                rob[i] = Math.Max(rob[i - 2] + nums[i], rob[i - 3] + nums[i]);
            }

            return Math.Max(rob[length - 1], rob[length - 2]);
        }
    }
}
