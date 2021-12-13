using System.Collections.Generic;

namespace LeetCode1790
{
    public class Solution
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            var length = s1.Length;

            var unMatchIndexList = new List<int>();
            for (var i = 0; i < length; i++)
            {
                var c1 = s1[i];
                var c2 = s2[i];
                if (c1 != c2)
                {
                    unMatchIndexList.Add(i);
                }
            }

            if (unMatchIndexList.Count == 0)
            {
                return true;
            }

            if (unMatchIndexList.Count == 1)
            {
                return false;
            }

            if (unMatchIndexList.Count > 2)
            {
                return false;
            }

            var firstUnMatchIndex = unMatchIndexList[0];
            var lastUnMatchIndex = unMatchIndexList[1];
            return s1[firstUnMatchIndex] == s2[lastUnMatchIndex] && s2[firstUnMatchIndex] == s1[lastUnMatchIndex];
        }
    }
}
