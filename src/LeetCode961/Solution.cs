using System;
using System.Collections.Generic;

namespace LeetCode961
{
    public class Solution
    {
        public int RepeatedNTimes(int[] nums)
        {
            var n = nums.Length / 2;
            var numCount = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                numCount.TryGetValue(num, out var count);
                count++;
                if (count == n)
                {
                    return num;
                }

                numCount[num] = count;
            }

            throw new InvalidOperationException();
        }
    }
}
