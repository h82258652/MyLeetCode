using System;
using System.Linq;

namespace LeetCode2028
{
    public class Solution
    {
        public int[] MissingRolls(int[] rolls, int mean, int n)
        {
            var m = rolls.Length;
            var totalLength = m + n;
            var total = mean * totalLength;
            var sum = rolls.Sum();
            var remain = total - sum;
            if (remain * 1d / n > 6d || remain * 1d / n < 1d)
            {
                return Array.Empty<int>();
            }
            var result = new int[n];
            var avg = remain / n;
            var mod = remain % n;
            for (var i = 0; i < n; i++)
            {
                var temp = avg;
                if (mod > 0)
                {
                    temp++;
                    mod--;
                }

                result[i] = temp;
            }

            return result.ToArray();
        }
    }
}
