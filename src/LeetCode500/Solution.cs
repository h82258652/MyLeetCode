using System.Collections.Generic;

namespace LeetCode500
{
    public class Solution
    {
        public string[] FindWords(string[] words)
        {
            var charMap = new[] { 2, 3, 3, 2, 1, 2, 2, 2, 1, 2, 2, 2, 3, 3, 1, 1, 1, 1, 2, 1, 1, 3, 1, 3, 1, 3 };

            var result = new List<string>();
            foreach (var word in words)
            {
                var firstChar = char.ToLower(word[0]);
                var line = charMap[firstChar - 'a'];
                var wordLength = word.Length;
                var match = true;
                for (var i = 1; i < wordLength; i++)
                {
                    var c = char.ToLower(word[i]);
                    if (charMap[c - 'a'] != line)
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    result.Add(word);
                }
            }

            return result.ToArray();
        }
    }
}
