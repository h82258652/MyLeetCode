using System;
using System.Collections.Generic;

namespace LeetCode953
{
    public class Solution
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            var wordCount = words.Length;
            if (wordCount == 1)
            {
                return true;
            }

            var orderValue = new Dictionary<char, int>();
            for (var i = 0; i < order.Length; i++)
            {
                orderValue[order[i]] = i;
            }

            orderValue[' '] = int.MinValue;

            for (var i = 0; i < wordCount - 1; i++)
            {
                var previousWord = words[i];
                var nextWord = words[i + 1];
                var compareWord = CompareWord(previousWord, nextWord, orderValue);
                if (!compareWord)
                {
                    return false;
                }
            }

            return true;
        }

        private bool CompareWord(string previousWord, string nextWord, Dictionary<char, int> orderValue)
        {
            var previousWordLength = previousWord.Length;
            var nextWordLength = nextWord.Length;
            var totalLength = Math.Max(previousWordLength, nextWordLength);
            for (var i = 0; i < totalLength; i++)
            {
                var previousWordChar = ' ';
                if (i < previousWordLength)
                {
                    previousWordChar = previousWord[i];
                }

                var nextWordChar = ' ';
                if (i < nextWordLength)
                {
                    nextWordChar = nextWord[i];
                }

                var previousWordValue = orderValue[previousWordChar];
                var nextWordValue = orderValue[nextWordChar];
                if (previousWordValue < nextWordValue)
                {
                    return true;
                }

                if (previousWordValue > nextWordValue)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
