using System.Text;

namespace LeetCode693
{
    public class Solution
    {
        public bool HasAlternatingBits(int n)
        {
            var twoBit = Cast(n);
            for (var i = 0; i < twoBit.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (twoBit[i] == '0')
                    {
                        return false;
                    }
                }
                else
                {
                    if (twoBit[i] == '1')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private string Cast(int n)
        {
            var builder = new StringBuilder();
            while (n > 0)
            {
                builder.Insert(0, n % 2);
                n /= 2;
            }
            return builder.ToString();
        }
    }
}
