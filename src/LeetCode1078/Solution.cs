using System.Collections.Generic;

namespace LeetCode1078
{
    public class Solution
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            var words = text.Split(' ');
            var result = new List<string>();

            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (word != first)
                {
                    continue;
                }

                if (i + 1 >= words.Length || words[i + 1] != second)
                {
                    continue;
                }

                if (i + 2 < words.Length)
                {
                    result.Add(words[i + 2]);
                }
            }

            return result.ToArray();
        }
    }
}
