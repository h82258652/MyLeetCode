using System;

namespace LeetCode121
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            // 最大利润
            var maxProfit = 0;

            // 最小买入
            var minBuy = prices[0];
            for (var i = 1; i < prices.Length; i++)
            {
                // 今天卖出的价钱
                var sell = prices[i];
                if (sell - minBuy > 0)
                {
                    maxProfit = Math.Max(maxProfit, sell - minBuy);
                }

                // 如果今天买入比历史买入更低，那就更新为今天的价格
                minBuy = Math.Min(minBuy, prices[i]);
            }

            return maxProfit;
        }
    }
}
