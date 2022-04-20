using System.Text;

namespace LeetCode2243
{
    public class Solution
    {
        public string DigitSum(string s, int k)
        {
            if (s.Length <= k)
            {
                return s;
            }

            var builder = new StringBuilder();
            for (var i = 0; i < s.Length; i += k)
            {
                var sum = 0;
                for (var j = i; j < i + k && j < s.Length; j++)
                {
                    sum += s[j] - '0';
                }

                builder.Append(sum);
            }

            return DigitSum(builder.ToString(), k);
        }
    }
}
