using System;
using System.Linq;

namespace LeetCode475
{
    public class Solution
    {
        public int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(houses);
            Array.Sort(heaters);

            var houseCount = houses.Length;
            var heaterCount = heaters.Length;

            // 从左往右，房子离供暖器最近的距离
            var left = new int[houseCount];
            Array.Fill(left, int.MaxValue);

            var heaterIndex = 0;
            var houseIndex = 0;
            while (heaterIndex < heaterCount && houseIndex < houseCount)
            {
                var heater = heaters[heaterIndex];
                var house = houses[houseIndex];
                if (house <= heater)
                {
                    left[houseIndex] = heater - house;
                    houseIndex++;
                }
                else
                {
                    heaterIndex++;
                }
            }

            // 从右往左，房子离供暖器最近的距离
            var right = new int[houseCount];
            Array.Fill(right, int.MaxValue);

            heaterIndex = heaterCount - 1;
            houseIndex = houseCount - 1;
            while (heaterIndex >= 0 && houseIndex >= 0)
            {
                var heater = heaters[heaterIndex];
                var house = houses[houseIndex];
                if (house >= heater)
                {
                    right[houseIndex] = house - heater;
                    houseIndex--;
                }
                else
                {
                    heaterIndex--;
                }
            }

            // 每个房间离供暖器最近的距离
            var nearest = new int[houseCount];
            for (var i = 0; i < houseCount; i++)
            {
                nearest[i] = Math.Min(left[i], right[i]);
            }

            // 要使供暖器覆盖到每个房子，选最大值
            return nearest.Max();
        }
    }
}
