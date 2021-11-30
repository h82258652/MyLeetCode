using System;

namespace LeetCode455
{
    public class Solution
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            var result = 0;
            Array.Sort(g);
            Array.Sort(s);

            var gLength = g.Length;
            var sLength = s.Length;
            var j = 0;
            for (var i = 0; i < gLength && j < sLength;)
            {
                if (g[i] <= s[j])
                {
                    result++;
                    i++;
                }

                j++;
            }

            return result;
        }
    }
}
