using System;

namespace LeetCode2016
{
    public class Solution
    {
        public int MaximumDifference(int[] nums)
        {
            var result = -1;

            var min = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                var num = nums[i];

                if (num <= min)
                {
                    min = num;
                    continue;
                }

                result = Math.Max(result, num - min);
            }

            return result;
        }
    }
}
