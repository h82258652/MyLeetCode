using System;

namespace LeetCode322
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            var counts = new int[amount + 1];
            Array.Fill(counts, -1);
            counts[0] = 0;
            foreach (var coin in coins)
            {
                if (coin < counts.Length)
                {
                    counts[coin] = 1;
                }
            }

            for (var i = 1; i <= amount; i++)
            {
                if (counts[i] >= 0)
                {
                    continue;
                }

                var count = -1;
                foreach (var coin in coins)
                {
                    if (i - coin < 0)
                    {
                        continue;
                    }

                    var temp = counts[i - coin];
                    if (temp == -1)
                    {
                        continue;
                    }

                    if (count == -1)
                    {
                        count = temp + 1;
                    }
                    else
                    {
                        count = Math.Min(count, temp + 1);
                    }
                }

                if (count != -1)
                {
                    counts[i] = count;
                }
            }

            return counts[amount];
        }
    }
}
