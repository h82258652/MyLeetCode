using System.Collections.Generic;

namespace LeetCode1748
{
    public class Solution
    {
        public int SumOfUnique(int[] nums)
        {
            var length = nums.Length;
            var numCount = new Dictionary<int, int>();
            for (var i = 0; i < length; i++)
            {
                var num = nums[i];
                numCount.TryGetValue(num, out var count);
                numCount[num] = count + 1;
            }

            var result = 0;
            foreach (var (num, count) in numCount)
            {
                if (count == 1)
                {
                    result += num;
                }
            }

            return result;
        }
    }
}
