using System.Collections.Generic;

namespace LeetCode2053
{
    public class Solution
    {
        public string KthDistinct(string[] arr, int k)
        {
            var counts = new Dictionary<string, int>();
            foreach (var s in arr)
            {
                counts.TryGetValue(s, out var count);
                count++;
                counts[s] = count;
            }

            foreach (var s in arr)
            {
                if (counts[s] > 1)
                {
                    continue;
                }

                if (k == 1)
                {
                    return s;
                }

                k--;
            }

            return string.Empty;
        }
    }
}
