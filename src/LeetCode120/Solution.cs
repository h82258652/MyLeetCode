using System;
using System.Collections.Generic;

namespace LeetCode120
{
    public class Solution
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            var sumTriangle = new List<List<int>>();

            for (var i = triangle.Count - 1; i >= 0; i--)
            {
                var line = triangle[i];
                if (i == triangle.Count - 1)
                {
                    sumTriangle.Add(new List<int>(line));
                    continue;
                }

                var previousLine = sumTriangle[sumTriangle.Count - 1];
                var sumLine = new List<int>();
                for (var j = 0; j < line.Count; j++)
                {
                    var val = line[j];
                    val += Math.Min(previousLine[j], previousLine[j + 1]);
                    sumLine.Add(val);
                }

                sumTriangle.Add(sumLine);
            }

            return sumTriangle[sumTriangle.Count - 1][0];
        }
    }
}
