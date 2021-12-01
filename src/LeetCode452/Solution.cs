using System.Linq;

namespace LeetCode452
{
    public class Solution
    {
        public int FindMinArrowShots(int[][] points)
        {
            points = points.OrderBy(temp => temp[1]).ToArray();

            var result = 0;
            var length = points.Length;
            for (var i = 0; i < length; i++)
            {
                var right = points[i][1];

                var j = i + 1;
                for (; j < length;)
                {
                    var left = points[j][0];
                    if (left <= right)
                    {
                        j++;
                        continue;
                    }

                    j--;
                    break;
                }

                i = j;
                result++;
            }

            return result;
        }
    }
}
