namespace LeetCode058
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var sLength = s.Length;
            var start = sLength - 1;
            while (true)
            {
                if (s[start] == ' ')
                {
                    start--;
                }
                else
                {
                    break;
                }
            }

            var end = start - 1;
            while (end >= 0)
            {
                if (s[end] == ' ')
                {
                    break;
                }

                end--;
            }

            return start - end;
        }
    }
}
