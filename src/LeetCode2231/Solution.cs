using System.Collections.Generic;

namespace LeetCode2231
{
    public class Solution
    {
        public int LargestInteger(int num)
        {
            var chars = num.ToString().ToCharArray();
            var oddIndex = new List<int>();
            var evenIndex = new List<int>();
            for (var i = 0; i < chars.Length; i++)
            {
                if ((chars[i] - '0') % 2 == 1)
                {
                    oddIndex.Add(i);
                }
                else
                {
                    evenIndex.Add(i);
                }
            }

            for (var i = 0; i < oddIndex.Count; i++)
            {
                for (var j = i + 1; j < oddIndex.Count; j++)
                {
                    var leftIndex = oddIndex[i];
                    var rightIndex = oddIndex[j];
                    if (chars[rightIndex] > chars[leftIndex])
                    {
                        (chars[rightIndex], chars[leftIndex]) = (chars[leftIndex], chars[rightIndex]);
                    }
                }
            }
            for (var i = 0; i < evenIndex.Count; i++)
            {
                for (var j = i + 1; j < evenIndex.Count; j++)
                {
                    var leftIndex = evenIndex[i];
                    var rightIndex = evenIndex[j];
                    if (chars[rightIndex] > chars[leftIndex])
                    {
                        (chars[rightIndex], chars[leftIndex]) = (chars[leftIndex], chars[rightIndex]);
                    }
                }
            }

            return int.Parse(new string(chars));
        }
    }
}
