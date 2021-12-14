namespace LeetCode557
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            var chars = s.ToCharArray();
            var length = chars.Length;

            var left = 0;
            var right = 0;
            for (; right < length; right++)
            {
                if (chars[right] == ' ')
                {
                    int innerLeft = left;
                    int innerRight = right - 1;
                    while (innerLeft < innerRight)
                    {
                        (chars[innerLeft], chars[innerRight]) = (chars[innerRight], chars[innerLeft]);
                        innerLeft++;
                        innerRight--;
                    }

                    left = right + 1;
                }
            }

            right--;
            while (left < right)
            {
                (chars[left], chars[right]) = (chars[right], chars[left]);
                left++;
                right--;
            }

            return new string(chars);
        }
    }
}
