using System;

namespace LeetCode485
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var result = 0;
            var length = nums.Length;
            var temp = 0;
            for (var i = 0; i < length; i++)
            {
                var num = nums[i];
                if (num == 1)
                {
                    temp++;
                }
                else
                {
                    result = Math.Max(result, temp);
                    temp = 0;
                }
            }

            result = Math.Max(result, temp);
            return result;
        }
    }
}
