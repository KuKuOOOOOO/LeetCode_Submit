/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices == null || prices.Length < 2)
            return 0;
        int MaxProfit = 0;
        int minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];
            else if (prices[i] - minPrice > MaxProfit)
                MaxProfit = prices[i] - minPrice;
        }
        return MaxProfit;
    }
}
// @lc code=end

