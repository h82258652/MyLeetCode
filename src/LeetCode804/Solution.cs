using System.Collections.Generic;
using System.Text;

namespace LeetCode804
{
    public class Solution
    {
        private static readonly string[] MorseMaps = new[]
        {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
            ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
        };

        public int UniqueMorseRepresentations(string[] words)
        {
            var set = new HashSet<string>();
            foreach (var word in words)
            {
                set.Add(Parse(word));
            }

            return set.Count;
        }

        private string Parse(string word)
        {
            var builder = new StringBuilder();
            foreach (var c in word)
            {
                builder.Append(MorseMaps[c - 'a']);
            }

            return builder.ToString();
        }
    }
}
