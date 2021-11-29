namespace LeetCode125
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            var left = 0;
            var right = s.Length - 1;
            while (left < right)
            {
                var leftChar = s[left];
                if (!char.IsLetterOrDigit(leftChar))
                {
                    left++;
                    continue;
                }

                var rightChar = s[right];
                if (!char.IsLetterOrDigit(rightChar))
                {
                    right--;
                    continue;
                }

                if (char.ToLower(leftChar) == char.ToLower(rightChar))
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
