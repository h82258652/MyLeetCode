using System.Linq;
using System.Text;

namespace LeetCode984
{
    public class Solution
    {
        public string StrWithout3a3b(int a, int b)
        {
            var result = new StringBuilder(a + b);
            char? lastChar = null;
            while (a >= 0 || b >= 0)
            {
                if (a <= 0)
                {
                    result.Append('b', b);
                    break;
                }

                if (b <= 0)
                {
                    result.Append('a', a);
                    break;
                }

                if (a > b)
                {
                    result.Append("aab");
                    a -= 2;
                    b--;
                    lastChar = 'b';
                }
                else if (a < b)
                {
                    result.Append("bba");
                    b -= 2;
                    a--;
                    lastChar = 'a';
                }
                else
                {
                    if (lastChar.HasValue && lastChar.Value == 'a')
                    {
                        result.Append(string.Concat(Enumerable.Repeat("ba", a)));
                        break;
                    }
                    else
                    {
                        result.Append(string.Concat(Enumerable.Repeat("ab", a)));
                        break;
                    }
                }
            }

            return result.ToString();
        }
    }
}
