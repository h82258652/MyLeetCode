namespace LeetCode917
{
    public class Solution
    {
        public string ReverseOnlyLetters(string s)
        {
            var chars = s.ToCharArray();
            var left = 0;
            var right = chars.Length - 1;
            while (left < right)
            {
                var leftChar = chars[left];
                if (!char.IsLetter(leftChar))
                {
                    left++;
                    continue;
                }

                var rightChar = chars[right];
                if (!char.IsLetter(rightChar))
                {
                    right--;
                    continue;
                }

                chars[left] = rightChar;
                chars[right] = leftChar;
                left++;
                right--;
            }

            return new string(chars);
        }
    }
}
