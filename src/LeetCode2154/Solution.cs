using System;

namespace LeetCode2154
{
    public class Solution
    {
        public int FindFinalValue(int[] nums, int original)
        {
            Array.Sort(nums);
            foreach (var num in nums)
            {
                if (num == original)
                {
                    original <<= 1;
                }
            }

            return original;
        }
    }
}
