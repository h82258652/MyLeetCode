namespace LeetCode009
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int temp = x;
            int palindrome = 0;
            while (temp > 0)
            {
                palindrome *= 10;
                palindrome += temp % 10;
                temp /= 10;
            }

            return x == palindrome;
        }
    }
}
