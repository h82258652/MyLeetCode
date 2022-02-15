using System;
using System.Collections.Generic;

namespace LeetCode1380
{
    public class Solution
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            var result = new List<int>();

            var m = matrix.Length;
            var n = matrix[0].Length;

            var min = new int[m];
            Array.Fill(min, int.MaxValue);
            var max = new int[n];
            Array.Fill(max, int.MinValue);

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var value = matrix[i][j];
                    min[i] = Math.Min(min[i], value);
                    max[j] = Math.Max(max[j], value);
                }
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (min[i] == max[j])
                    {
                        result.Add(min[i]);
                    }
                }
            }

            return result;
        }
    }
}
