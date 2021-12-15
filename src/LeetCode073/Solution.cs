using System.Collections.Generic;

namespace LeetCode073
{
    public class Solution
    {
        public void SetZeroes(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;

            var zeroLines = new HashSet<int>();
            var zeroColumns = new HashSet<int>();

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        zeroLines.Add(i);
                        zeroColumns.Add(j);
                    }
                }
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (zeroLines.Contains(i) ||
                        zeroColumns.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}
