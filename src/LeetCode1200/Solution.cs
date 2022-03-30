using System;
using System.Collections.Generic;

namespace LeetCode1200
{
    public class Solution
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);

            var div = int.MaxValue;
            var length = arr.Length;
            for (var i = 1; i < length; i++)
            {
                div = Math.Min(div, arr[i] - arr[i - 1]);
            }

            var result = new List<IList<int>>();

            var set = new HashSet<int>(arr);
            foreach (var i in arr)
            {
                if (set.Contains(i + div))
                {
                    result.Add(new List<int> { i, i + div });
                }
            }

            return result;
        }
    }
}
