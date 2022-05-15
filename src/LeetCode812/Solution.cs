using System;

namespace LeetCode812
{
    public class Solution
    {
        public double LargestTriangleArea(int[][] points)
        {
            var pointCount = points.Length;
            var largestSize = 0d;
            for (var i = 0; i < pointCount; i++)
            {
                var point1 = points[i];
                var x1 = point1[0];
                var y1 = point1[1];
                for (var j = i + 1; j < pointCount; j++)
                {
                    var point2 = points[j];
                    var x2 = point2[0];
                    var y2 = point2[1];
                    for (var k = j + 1; k < pointCount; k++)
                    {
                        var point3 = points[k];
                        var x3 = point3[0];
                        var y3 = point3[1];
                        var size = CalcSize(x1, y1, x2, y2, x3, y3);
                        largestSize = Math.Max(largestSize, size);
                    }
                }
            }

            return largestSize;
        }

        private double CalcSize(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            return Math.Abs((x1 * y2 + x2 * y3 + x3 * y1 - x1 * y3 - x2 * y1 - x3 * y2) / 2d);
        }
    }
}
