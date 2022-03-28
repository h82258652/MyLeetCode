using System;

namespace LeetCode643
{
    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            var sum = 0d;
            var i = 0;
            for (; i < k; i++)
            {
                sum += nums[i];
            }

            var avg = sum / k;

            for (; i < nums.Length; i++)
            {
                sum -= nums[i - k];
                sum += nums[i];
                avg = Math.Max(avg, sum / k);
            }

            return avg;
        }
    }
}
