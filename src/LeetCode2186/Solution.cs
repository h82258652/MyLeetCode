using System;

namespace LeetCode2186
{
    public class Solution
    {
        public int MinSteps(string s, string t)
        {
            var sCount = new int[26];
            var tCount = new int[26];
            foreach (var c in s)
            {
                sCount[c - 'a']++;
            }

            foreach (var c in t)
            {
                tCount[c - 'a']++;
            }

            var totalCount = 0;
            for (var i = 0; i < 26; i++)
            {
                totalCount += Math.Abs(sCount[i] - tCount[i]);
            }

            return totalCount;
        }
    }
}
