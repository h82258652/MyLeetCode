using System.Collections.Generic;

namespace LeetCode2133
{
    public class Solution
    {
        public bool CheckValid(int[][] matrix)
        {
            var n = matrix.Length;
            for (var i = 0; i < n; i++)
            {
                var set = new HashSet<int>();
                for (var j = 0; j < n; j++)
                {
                    var num = matrix[i][j];
                    if (set.Contains(num))
                    {
                        return false;
                    }

                    set.Add(num);
                }
            }

            for (var j = 0; j < n; j++)
            {
                var set = new HashSet<int>();
                for (var i = 0; i < n; i++)
                {
                    var num = matrix[i][j];
                    if (set.Contains(num))
                    {
                        return false;
                    }

                    set.Add(num);
                }
            }

            return true;
        }
    }
}
