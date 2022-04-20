using System;

namespace LeetCode2239
{
    public class Solution
    {
        public int FindClosestNumber(int[] nums)
        {
            Array.Sort(nums);
            var minDistance = int.MaxValue;
            var result = int.MaxValue;
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                var distance = Math.Abs(nums[i]);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    result = nums[i];
                }
            }

            return result;
        }
    }
}
