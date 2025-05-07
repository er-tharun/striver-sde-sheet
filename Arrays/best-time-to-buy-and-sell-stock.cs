//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        int minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            int cost = prices[i] - minPrice;
            minPrice = Math.Min(prices[i], minPrice);
            profit = Math.Max(cost, profit);
        }

        return profit;
    }
}