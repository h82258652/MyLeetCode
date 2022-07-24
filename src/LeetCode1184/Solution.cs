using System;

namespace LeetCode1184
{
    public class Solution
    {
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            if (start == destination)
            {
                return 0;
            }

            if (destination < start)
            {
                var temp = start;
                start = destination;
                destination = temp;
            }

            var sum = 0;
            var target = 0;
            var n = distance.Length;
            for (var i = 0; i < n; i++)
            {
                var temp = distance[i];
                sum += temp;
                if (i >= start && i < destination)
                {
                    target += temp;
                }
            }

            return Math.Min(target, sum - target);
        }
    }
}
