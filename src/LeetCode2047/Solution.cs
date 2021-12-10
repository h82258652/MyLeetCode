using System;

namespace LeetCode2047
{
    public class Solution
    {
        public int CountValidWords(string sentence)
        {
            var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var result = 0;
            foreach (var word in words)
            {
                if (IsValid(word))
                {
                    result++;
                }
            }

            return result;
        }

        private bool IsValid(string word)
        {
            var length = word.Length;
            var connectCount = 0;
            for (var i = 0; i < length; i++)
            {
                var c = word[i];
                if (c >= '0' && c <= '9')
                {
                    return false;
                }

                if (c == '-')
                {
                    if (connectCount > 0)
                    {
                        return false;
                    }

                    if (i <= 0 || i >= length - 1)
                    {
                        return false;
                    }

                    if (!char.IsLower(word[i - 1]) || !char.IsLower(word[i + 1]))
                    {
                        return false;
                    }

                    connectCount++;
                }

                if (c == '!' || c == ',' || c == '.')
                {
                    if (i != length - 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
