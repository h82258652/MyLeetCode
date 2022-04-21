using System;
using System.Text;

namespace LeetCode824
{
    public class Solution
    {
        public string ToGoatLatin(string sentence)
        {
            var words = sentence.Split(' ');
            var builder = new StringBuilder();
            for (var i = 0; i < words.Length; i++)
            {
                var newWord = ChangeWord(words[i], i);
                builder.Append(newWord);
                if (i != words.Length - 1)
                {
                    builder.Append(' ');
                }
            }

            return builder.ToString();
        }

        private string ChangeWord(string word, int index)
        {
            if (word.StartsWith("a", StringComparison.OrdinalIgnoreCase) ||
                word.StartsWith("e", StringComparison.OrdinalIgnoreCase) ||
                word.StartsWith("i", StringComparison.OrdinalIgnoreCase) ||
                word.StartsWith("o", StringComparison.OrdinalIgnoreCase) ||
                word.StartsWith("u", StringComparison.OrdinalIgnoreCase))
            {
                return word + "ma" + new string('a', index + 1);
            }
            else
            {
                var firstChar = word.Substring(0, 1);
                var remain = word.Substring(1);
                return remain + firstChar + "ma" + new string('a', index + 1);
            }
        }
    }
}
