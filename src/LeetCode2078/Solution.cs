using System;

namespace LeetCode2078
{
    public class Solution
    {
        public int MaxDistance(int[] colors)
        {
            var colorMinIndex = new int[101];
            Array.Fill(colorMinIndex, int.MaxValue);
            var colorMaxIndex = new int[101];
            Array.Fill(colorMaxIndex, int.MinValue);

            var length = colors.Length;
            for (var i = 0; i < length; i++)
            {
                var color = colors[i];
                colorMinIndex[color] = Math.Min(colorMinIndex[color], i);
                colorMaxIndex[color] = Math.Max(colorMaxIndex[color], i);
            }

            var result = 0;
            for (var a = 0; a <= 100; a++)
            {
                var aLeft = colorMinIndex[a];
                if (aLeft == int.MaxValue)
                {
                    continue;
                }

                var aRight = colorMaxIndex[a];
                if (aRight == int.MinValue)
                {
                    continue;
                }

                for (var b = 0; b <= 100; b++)
                {
                    if (a == b)
                    {
                        continue;
                    }

                    var bLeft = colorMinIndex[b];
                    if (bLeft == int.MaxValue)
                    {
                        continue;
                    }

                    var bRight = colorMaxIndex[b];
                    if (bRight == int.MinValue)
                    {
                        continue;
                    }

                    result = Math.Max(result, Math.Max(Math.Abs(aLeft - bRight), Math.Abs(bLeft - aRight)));
                }
            }

            return result;
        }
    }
}
