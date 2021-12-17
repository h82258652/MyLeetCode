using System;
using System.Collections.Generic;

namespace JianZhi03
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)
        /// 空间复杂度 O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindRepeatNumber(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var num in nums)
            {
                if (!set.Add(num))
                {
                    return num;
                }
            }

            throw new InvalidOperationException();
        }
    }
}
