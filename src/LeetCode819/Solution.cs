using System;
using System.Linq;

namespace LeetCode819
{
    public class Solution
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            return paragraph
                .Split(new char[] { ' ', '!', '?', '\'', ',', ';', '.' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(temp => temp.ToLowerInvariant())
                .Where(temp => !banned.Contains(temp))
                .GroupBy(temp => temp)
                .OrderByDescending(temp => temp.Count())
                .First().Key;
        }
    }
}
