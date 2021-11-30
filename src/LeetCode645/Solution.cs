using System.Collections.Generic;
using System.Linq;

namespace LeetCode645
{
    public class Solution
    {
        public int[] FindErrorNums(int[] nums)
        {
            var repeatNum = 0;
            var length = nums.Length;

            var set = new HashSet<int>();
            foreach (var num in nums)
            {
                if (set.Contains(num))
                {
                    repeatNum = num;
                }
                else
                {
                    set.Add(num);
                }
            }

            var sum = length * (length + 1) / 2;
            var missingNum = sum - set.Sum();
            return new[] { repeatNum, missingNum };
        }
    }
}
