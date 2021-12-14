using System;

namespace LeetCode189
{
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            var length = nums.Length;
            k %= length;
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, length - k);
        }
    }
}
