using System.Collections.Generic;
using System.Text;

namespace LeetCode2255
{
    public class Solution
    {
        public int CountPrefixes(string[] words, string s)
        {
            var prefixes = new HashSet<string>();
            var buffer = new StringBuilder();
            foreach (var c in s)
            {
                buffer.Append(c);
                prefixes.Add(buffer.ToString());
            }

            var count = 0;
            foreach (var word in words)
            {
                if (prefixes.Contains(word))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
