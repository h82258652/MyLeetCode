using System.Collections.Generic;

namespace LeetCode989
{
    public class Solution
    {
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            for (var i = num.Length - 1; i >= 0; i--)
            {
                var val = num[i] + k;
                num[i] = val % 10;
                k = val / 10;
            }

            var result = new List<int>();
            while (k > 0)
            {
                result.Insert(0, k % 10);
                k /= 10;
            }

            result.AddRange(num);

            return result;
        }
    }
}
