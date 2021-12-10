using System;
using System.Linq;

namespace LeetCode748
{
    public class Solution
    {
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            words = words
                .Select((value, index) => new
                {
                    value = value,
                    index = index
                })
                .OrderBy(temp => temp.value.Length)
                .ThenBy(temp => temp.index)
                .Select(temp => temp.value)
                .ToArray();

            var charCountInLicensePlate = new int[26];
            foreach (var c in licensePlate)
            {
                if (char.IsLetter(c))
                {
                    charCountInLicensePlate[char.ToLower(c) - 'a']++;
                }
            }

            foreach (var word in words)
            {
                var charCountInWord = new int[26];
                foreach (var c in word)
                {
                    charCountInWord[c - 'a']++;
                }

                var match = true;
                for (var i = 0; i < 26; i++)
                {
                    if (charCountInWord[i] < charCountInLicensePlate[i])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    return word;
                }
            }

            throw new InvalidOperationException();
        }
    }
}
