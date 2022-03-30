using System;

namespace LeetCode2160
{
    public class Solution
    {
        public int MinimumSum(int num)
        {
            var ge = num % 10;
            var shi = (num / 10) % 10;
            var bai = (num / 10 / 10) % 10;
            var qian = (num / 10 / 10 / 10) % 10;
            var bits = new[] { ge, shi, bai, qian };
            Array.Sort(bits);

            return bits[0] * 10 + bits[1] * 10 + bits[2] + bits[3];
        }
    }
}
