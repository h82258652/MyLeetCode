using System.Collections.Generic;
using System.Linq;

namespace LeetCode648
{
    public class Solution
    {
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            var words = sentence.Split(' ');
            dictionary = dictionary.OrderBy(temp => temp.Length).ToList();
            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i];
                foreach (var root in dictionary)
                {
                    if (word.StartsWith(root))
                    {
                        words[i] = root;
                        break;
                    }
                }
            }

            return string.Join(' ', words);
        }
    }
}
