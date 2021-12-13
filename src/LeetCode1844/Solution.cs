using System.Text;

namespace LeetCode1844
{
    public class Solution
    {
        public string ReplaceDigits(string s)
        {
            var length = s.Length;
            var result = new StringBuilder(length);

            var previous = '\0';
            for (var i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                {
                    previous = s[i];
                    result.Append(previous);
                    continue;
                }

                result.Append((char)(previous + (s[i] - '0')));
            }

            return result.ToString();
        }
    }
}
