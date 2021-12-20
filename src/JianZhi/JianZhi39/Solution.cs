using System;
using System.Collections.Generic;

namespace JianZhi39
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)
        /// 空间复杂度 O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement(int[] nums)
        {
            var length = nums.Length;
            var numCount = new Dictionary<int, int>();

            for (var i = 0; i < length; i++)
            {
                var num = nums[i];
                numCount.TryGetValue(num, out var count);
                count++;
                if (count == (length + 1) / 2)
                {
                    return num;
                }

                numCount[num] = count;
            }

            throw new InvalidOperationException();
        }
    }
}
