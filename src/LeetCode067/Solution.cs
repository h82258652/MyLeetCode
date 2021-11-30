using System.Text;

namespace LeetCode067
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var result = new StringBuilder();

            var plus = 0;

            int i = a.Length - 1;
            int j = b.Length - 1;

            while (i >= 0 || j >= 0)
            {
                var bit = plus;

                if (i >= 0)
                {
                    if (a[i] == '1')
                    {
                        bit++;
                    }
                }

                if (j >= 0)
                {
                    if (b[j] == '1')
                    {
                        bit++;
                    }
                }

                plus = bit > 1 ? 1 : 0;

                if (bit % 2 == 0)
                {
                    result.Insert(0, '0');
                }
                else
                {
                    result.Insert(0, '1');
                }

                i--;
                j--;
            }

            if (plus > 0)
            {
                result.Insert(0, '1');
            }

            return result.ToString();
        }
    }
}
