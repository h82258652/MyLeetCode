using System;
using System.Collections.Generic;

namespace LeetCode954
{
    public class Solution
    {
        public bool CanReorderDoubled(int[] arr)
        {
            Array.Sort(arr);
            var positives = new List<int>();
            var zeros = new List<int>();
            var minus = new List<int>();

            foreach (var i in arr)
            {
                if (i > 0)
                {
                    positives.Add(i);
                }
                else if (i == 0)
                {
                    zeros.Add(i);
                }
                else
                {
                    minus.Add(i);
                }
            }

            if (positives.Count % 2 == 1 ||
                zeros.Count % 2 == 1 ||
                minus.Count % 2 == 1)
            {
                return false;
            }

            while (positives.Count > 0)
            {
                var last = positives[^1];
                if (last % 2 == 1)
                {
                    return false;
                }

                var half = last / 2;
                if (positives.Remove(half))
                {
                    positives.Remove(last);
                    continue;
                }

                return false;
            }

            while (minus.Count > 0)
            {
                var first = minus[0];
                if (first % 2 == -1)
                {
                    return false;
                }

                var half = first / 2;
                if (minus.Remove(half))
                {
                    minus.Remove(first);
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
