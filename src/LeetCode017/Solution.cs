using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode017
{
    public class Solution
    {
        private static readonly Dictionary<char, char[]> DigitLetterMap = new Dictionary<char, char[]>()
        {
            ['2'] = new[] { 'a', 'b', 'c' },
            ['3'] = new[] { 'd', 'e', 'f' },
            ['4'] = new[] { 'g', 'h', 'i' },
            ['5'] = new[] { 'j', 'k', 'l' },
            ['6'] = new[] { 'm', 'n', 'o' },
            ['7'] = new[] { 'p', 'q', 'r', 's' },
            ['8'] = new[] { 't', 'u', 'v' },
            ['9'] = new[] { 'w', 'x', 'y', 'z' }
        };

        public IList<string> LetterCombinations(string digits)
        {
            var length = digits.Length;
            var result = new List<StringBuilder>();

            foreach (var digit in digits)
            {
                if (result.Count == 0)
                {
                    foreach (var c in DigitLetterMap[digit])
                    {
                        var buffer = new StringBuilder(length);
                        buffer.Append(c);
                        result.Add(buffer);
                    }
                }
                else
                {
                    var letters = DigitLetterMap[digit];
                    var letterCount = letters.Length;
                    var previousCount = result.Count;
                    for (var resultIndex = 0; resultIndex < previousCount; resultIndex++)
                    {
                        var previous = result[resultIndex];

                        for (var i = 0; i < letterCount; i++)
                        {
                            if (i < letterCount - 1)
                            {
                                var buffer = new StringBuilder(length);
                                buffer.Append(previous);
                                buffer.Append(letters[i]);
                                result.Add(buffer);
                            }
                            else
                            {
                                previous.Append(letters[i]);
                            }
                        }
                    }
                }
            }

            return result.Select(temp => temp.ToString()).ToList();
        }
    }
}
