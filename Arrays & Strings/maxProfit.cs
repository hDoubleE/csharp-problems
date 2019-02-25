// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
// Say you have an array for which the ith element is the price of a given stock on day i.
// If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.

// Note that you cannot sell a stock before you buy one.Input: [7,1,5,3,6,4]
// Output: 5
// Explanation: 
// Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
// Not 7-1 = 6, as selling price needs to be larger than buying price.

// Simple dynamic programming store global max profit variable and compare.
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length <= 1)
        {
            return 0;
        }
        
        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            
            if (prices[i] - minPrice > maxProfit)
            {
                maxProfit = prices[i] - minPrice;
            }
            // If both false, loop continues, searching for better profit.
        }
        return maxProfit;
    }
}