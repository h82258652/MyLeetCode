namespace LeetCode2108
{
    public class Solution
    {
        public string FirstPalindrome(string[] words)
        {
            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    return word;
                }
            }

            return string.Empty;
        }

        private bool IsPalindrome(string word)
        {
            for (int i = 0, j = word.Length - 1; i < j; i++, j--)
            {
                if (word[i] != word[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
