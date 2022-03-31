using System;

namespace LeetCode2148
{
    public class Solution
    {
        public int CountElements(int[] nums)
        {
            Array.Sort(nums);
            int left = 0;
            int min = nums[left];
            int right = nums.Length - 1;
            int max = nums[right];
            while (left < nums.Length && min == nums[left])
            {
                left++;
            }

            while (right >= 0 && max == nums[right])
            {
                right--;
            }

            return Math.Max(0, right - left + 1);
        }
    }
}
