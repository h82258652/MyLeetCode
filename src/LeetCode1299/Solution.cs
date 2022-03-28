using System;

namespace LeetCode1299
{
    public class Solution
    {
        public int[] ReplaceElements(int[] arr)
        {
            var max = 0;
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                if (i == arr.Length - 1)
                {
                    max = arr[i];
                    arr[i] = -1;
                }
                else
                {
                    var current = arr[i];
                    arr[i] = max;
                    max = Math.Max(max, current);
                }
            }

            return arr;
        }
    }
}
