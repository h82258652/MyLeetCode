using System.Linq;

namespace LeetCode2185
{
    public class Solution
    {
        public int PrefixCount(string[] words, string pref)
        {
            return words.Count(temp => temp.StartsWith(pref));
        }
    }
}
