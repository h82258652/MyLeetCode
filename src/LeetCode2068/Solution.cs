using System;

namespace LeetCode2068
{
    public class Solution
    {
        public bool CheckAlmostEquivalent(string word1, string word2)
        {
            var word1CharCount = new int[26];
            foreach (var c in word1)
            {
                word1CharCount[c - 'a']++;
            }

            var word2CharCount = new int[26];
            foreach (var c in word2)
            {
                word2CharCount[c - 'a']++;
            }

            for (var i = 0; i < 26; i++)
            {
                if (Math.Abs(word1CharCount[i] - word2CharCount[i]) > 3)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
