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
        }
        return maxProfit;
    }
    public int MaxSubArray(int[] nums)
    {
            int maxSum = nums[0];
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (currentSum + nums[i] > nums[i])
                {
                    currentSum += nums[i];
                }

                else
                {
                    currentSum = nums[i];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            return maxSum;
        }
}