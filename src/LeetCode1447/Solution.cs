using System.Collections.Generic;

namespace LeetCode1447
{
    public class Solution
    {
        public IList<string> SimplifiedFractions(int n)
        {
            if (n == 1)
            {
                return new List<string>();
            }

            var result = new List<string>();

            for (var j = 2; j <= n; j++)
            {
                for (var i = 1; i < j; i++)
                {
                    var gcd = Gcd(i, j);
                    if (gcd == 1)
                    {
                        result.Add($"{i}/{j}");
                    }
                }
            }

            return result;
        }

        private static int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }
    }
}
