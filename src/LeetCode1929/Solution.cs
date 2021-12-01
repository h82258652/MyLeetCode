using System;

namespace LeetCode1929
{
    public class Solution
    {
        public int[] GetConcatenation(int[] nums)
        {
            var length = nums.Length;
            var result = new int[length << 1];
            Array.Copy(nums, 0, result, 0, length);
            Array.Copy(nums, 0, result, length, length);
            return result;
        }
    }
}
